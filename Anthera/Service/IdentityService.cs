using Anthera_API.Contracts;
using Anthera_API.Contracts.v1;
using Anthera_API.Data;
using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using DatabaseLookups;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly DataContext _dataContext;
        private readonly JwtTokenService _jwtTokenService;
        private readonly IPasswordHasher _passwordHasher;
        public IdentityService(DataContext dataContext, IUserService userService, IConfiguration configuration, IPasswordHasher passwordHasher, JwtTokenService jwtTokenService)
        {
            _dataContext = dataContext;
            _configuration = configuration;
            _userService = userService;
            _passwordHasher = passwordHasher;
            _jwtTokenService = jwtTokenService;
        }
        public async Task<(ErrorResult, IAuthResponse, User)> signinAsync(IUserRequest signinRequest, IAuthResponse authResponse)
        {
            var ecr = new ErrorResult();
            try
            {
                //map model to a User object.
                var userRequest = signinRequest.MapToModel(new User());

                //check if user exits with a email and password from request.
                var foundUser = _dataContext.User.SingleOrDefault(r => r.EmailAddress.Equals(userRequest.EmailAddress));

                //unhash and verify password, then generate jwt token
                if (foundUser != null && _passwordHasher.VerfilyPassword(userRequest.Password, foundUser.Password))
                {
                    //get role name form db
                    var role = _dataContext.Role.FirstOrDefault(r => r.Id == foundUser.RoleId);

                    if (role != null)
                    {
                        //generate token and add to auth response.
                        authResponse.SetTokens(
                            _jwtTokenService.GenerateAccessToken(foundUser, role.RoleName),
                            _jwtTokenService.GenerateRefreshToken());

                        //insert refresh token to db.
                        await InsertNewRefreshToken(authResponse, foundUser);

                        return (ecr, authResponse, foundUser);
                    }
                }

                //no user with email & password found.
                ecr.SetEndUserError(ApiConstant.Errors.Requests.EmailOrPasswordInvalid);
            }
            catch (Exception ex)
            {
                ecr.MapException(ex);
            }
            ecr.IsSuccess = false;
            return (ecr, null, null);
        }

        public async Task<(ErrorResult, IAuthResponse, User)> SignupAsync(IUserRequest userRequest, IAuthResponse authResponse)
        {
            var ecr = new ErrorResult();
            try
            {
                var user = _userService.Create(userRequest);
                if (user != null)
                {

                    //hash passwrod.
                    user.Password = _passwordHasher.HashPassword(user.Password);

                    await _dataContext.Database.BeginTransactionAsync();

                    //get role name form db
                    var role = _dataContext.Role.FirstOrDefault(r => r.Id == user.RoleId);

                    if (role != null)
                    {
                        //insert user to db.
                        await _dataContext.AddAsync(user);
                        await _dataContext.SaveChangesAsync();

                        //generate token and add to auth response.
                        authResponse.SetTokens(
                            _jwtTokenService.GenerateAccessToken(user, role.RoleName),
                            _jwtTokenService.GenerateRefreshToken());

                        //insert refresh token to db.
                        await InsertNewRefreshToken(authResponse, user);

                        //commit transaction.
                        _dataContext.Database.CommitTransaction();
                        return (ecr, authResponse, user);
                    }
                }
            }
            catch (Exception ex)
            {
                ecr.MapException(ex);
            }
            ecr.IsSuccess = false;
            return (ecr, null, null);
        }

        public async Task<ErrorResult> SignoutAsync(User loggedUser, string refreshToken)
        {
            var er = new ErrorResult();
            try
            {
               var refreshTokenInDb = _dataContext.RefreshToken.FirstOrDefault(r => r.UserId == loggedUser.Id && r.RefreshTokenValue == refreshToken);
                if(refreshTokenInDb != null)
                {
                    //remove refresh token from db.
                    _dataContext.RefreshToken.Remove(refreshTokenInDb);
                    await _dataContext.SaveChangesAsync();
                    return er;
                }
            }catch(Exception ex)
            {
                er.MapException(ex);
            }
            er.IsSuccess = false;
            er.SetEndUserError(ApiConstant.Errors.GenericError);
            return er;
        }

        public void GetLoggedUser(in ClaimsPrincipal claimsPrincipal, out User user, out RoleEnum role)
        {
            user = new User
            {
                Id = Int32.Parse(claimsPrincipal.FindFirstValue("id")),
                EmailAddress = claimsPrincipal.FindFirstValue(ClaimTypes.Email),
                Name = claimsPrincipal.FindFirstValue(ClaimTypes.Name)
            };

            //map role
            var _roleName = claimsPrincipal.FindFirstValue(ClaimTypes.Role);

            if (_roleName.Equals(DatbaseConstants.Values.Role.ANTHER_USER))
            {
                role = RoleEnum.ANTHERA_ADMIN;
                return;
            }
            role = RoleEnum.ANTHERA_USER;
        }

        public async Task<(ErrorResult, IAuthResponse)> ValidateRefreshTokenAsync(string refreshTokenValue, IAuthResponse authResponse)
        {
            var er = new ErrorResult();
            try
            {
                var refreshToken = _dataContext.RefreshToken.FirstOrDefault(r => r.RefreshTokenValue == refreshTokenValue);
                bool isValid = _jwtTokenService.ValidateRefreshToken(refreshTokenValue, out DateTime expire);

                if (refreshToken != null && !refreshToken.IsInvalidated && isValid)
                {
                    //get user by id.
                    var user = _dataContext.User.FirstOrDefault(r => r.Id == refreshToken.UserId);

                    //get role name form db
                    var role = _dataContext.Role.FirstOrDefault(r => r.Id == user.RoleId);

                    await _dataContext.Database.BeginTransactionAsync();

                    //remove old refresh token form db.
                    _dataContext.RefreshToken.Remove(refreshToken);

                    //generate new access token & refresh token
                    authResponse.SetTokens(
                        _jwtTokenService.GenerateAccessToken(user, role.RoleName),
                        _jwtTokenService.GenerateRefreshToken()
                        );

                    //insert new refresh token
                    await InsertNewRefreshToken(authResponse, user);

                    _dataContext.Database.CommitTransaction();

                    return (er, authResponse);
                }
            }
            catch (Exception ex)
            {
                er.MapException(ex);
            }
            er.IsSuccess = false;
            return (er, null);
        }

        private async Task InsertNewRefreshToken(IAuthResponse authResponse, User user)
        {
            await _dataContext.RefreshToken.AddAsync(new RefreshToken
            {
                RefreshTokenValue = authResponse.GetRefreshToken(),
                IssuedAt = DateTime.UtcNow,
                IsInvalidated = false,
                UserId = user.Id,
            });
            await _dataContext.SaveChangesAsync();
        }
    }
}
