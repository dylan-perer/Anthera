using Anthera_API.Contracts;
using Anthera_API.Contracts.v1;
using Anthera_API.Data;
using Anthera_API.Extension;
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
        private readonly DataContext _dataContext;
        private readonly JwtTokenService _jwtTokenService;
        private readonly IPasswordHasher _passwordHasher;
        public IdentityService(DataContext dataContext, IUserService userService, IPasswordHasher passwordHasher, JwtTokenService jwtTokenService)
        {
            _dataContext = dataContext;
            _userService = userService;
            _passwordHasher = passwordHasher;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<(IAuthResponse, User)> signinAsync(IUserRequest signinRequest, IAuthResponse authResponse)
        {
            //map model to a User object.
            var userRequest = signinRequest.MapToModel(new User());

            //check if user exits with a email and password from request.
            var foundUser = _userService.GetUserByEmail(userRequest.EmailAddress);

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

                    return (authResponse, foundUser);
                }
            }
            throw new AntheraException().Throw("Sorry, email or password is incorrect. Please try again.");
        }

        public async Task<(IAuthResponse, User)> SignupAsync(IUserRequest userRequest, IAuthResponse authResponse)
        {
            var user = _userService.Create(userRequest);

            //hash passwrod.
            user.Password = _passwordHasher.HashPassword(user.Password);


            //get role name form db
            var role = _dataContext.Role.FirstOrDefault(r => r.Id == user.RoleId);
            if (role is null)
            {
                throw new AntheraException().Throw("Failed to find role in signup.", isDevError: true);
            }

            try
            {
                await _dataContext.Database.BeginTransactionAsync();

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
                return (authResponse, user);
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong signing you up.");
            }
            
        }

        public async Task SignoutAsync(User loggedUser, string refreshToken)
        {
            var refreshTokenInDb = _dataContext.RefreshToken.FirstOrDefault(r => r.UserId == loggedUser.Id && r.RefreshTokenValue == refreshToken);
            if (refreshTokenInDb is null)
            {
                throw new AntheraException().Throw("Failed to find refreshtoken in db.", isDevError: true);
            }

            try
            {
                //remove refresh token from db.
                _dataContext.RefreshToken.Remove(refreshTokenInDb);
                await _dataContext.SaveChangesAsync();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong signing you out.");
            }
        }

        public void GetLoggedUser(in ClaimsPrincipal claimsPrincipal, out User user, out RoleEnum role)
        {
            try
            {
                user = new User
                {
                    Id = Int32.Parse(claimsPrincipal.FindFirstValue("id")),
                    EmailAddress = claimsPrincipal.FindFirstValue(ClaimTypes.Email),
                    Name = claimsPrincipal.FindFirstValue(ClaimTypes.Name),
                };

                //map role
                var _roleName = claimsPrincipal.FindFirstValue(ClaimTypes.Role);
                user.RoleId = DbInitializer.StringToByte(_roleName, DbInitializer.Values.role);

                if (_roleName.Equals(DbInitializer.Values.Role.ANTHER_USER))
                {
                    role = RoleEnum.ANTHERA_ADMIN;
                    return;
                }
                role = RoleEnum.ANTHERA_USER;
            }
            catch
            {
                throw new AntheraException().Throw("Unauthorized, please try signing in again.", 401);
            }
        }

        public Role GetUserRole(User user)
        {
            //get role name form db
            var role = _dataContext.Role.FirstOrDefault(r => r.Id == user.RoleId);
            if(role is null)
            {
                throw new AntheraException().Throw("Failed to find user's role.", isDevError: true);
            }
            return role;
        }

        public async Task<IAuthResponse> ValidateRefreshTokenAsync(string refreshTokenValue, IAuthResponse authResponse)
        {
            var refreshTokenInDb = _dataContext.RefreshToken.FirstOrDefault(r => r.RefreshTokenValue == refreshTokenValue);
            bool isValid = _jwtTokenService.ValidateRefreshToken(refreshTokenValue, out DateTime expire);

            if (refreshTokenInDb is null || !isValid || refreshTokenInDb.IsInvalidated)
            {
                throw new AntheraException().Throw("Invalid token.");
            }

            //get user by id.
            var user = _userService.GetUserById(refreshTokenInDb.UserId);

            //get role name form db
            var role = GetUserRole(user);

            try
            {
                await _dataContext.Database.BeginTransactionAsync();

                //remove old refresh token form db.
                _dataContext.RefreshToken.Remove(refreshTokenInDb);

                //generate new access token & refresh token
                authResponse.SetTokens(
                    _jwtTokenService.GenerateAccessToken(user, role.RoleName),
                    _jwtTokenService.GenerateRefreshToken()
                    );

                //insert new refresh token
                await InsertNewRefreshToken(authResponse, user);

                _dataContext.Database.CommitTransaction();
                return authResponse;
            }
            catch
            {
                throw new AntheraException().Throw("Failed inserting new token into db.", isDevError: true);
            }

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
