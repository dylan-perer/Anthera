using Anthera_API.Contracts;
using Anthera_API.Contracts.v1;
using Anthera_API.Data;
using Anthera_API.Models;
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
        public IdentityService(DataContext dataContext, IUserService userService, IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;
            _userService = userService;
        }
        public Task<(ECResult, User)> signin(IUserRequest userRequest)
        {
            throw new SecurityTokenNotYetValidException();
        }

        public async Task<(ECResult, IAuthResponse, User)> SignupAsync(IUserRequest userRequest, IAuthResponse authResponse)
        {
            var ecr = new ECResult();
            try
            {
                var user = _userService.Create(userRequest);
                if(user != null)
                {
                    await _dataContext.Database.BeginTransactionAsync();
                    
                    //insert user to db
                    await _dataContext.AddAsync(user);
                    await _dataContext.SaveChangesAsync();

                    //insert refresh token
                    authResponse = await GenerateToken(user, authResponse);


                    //commit transaction
                    _dataContext.Database.CommitTransaction();
                    return (ecr, authResponse, user);
                }
            }
            catch (Exception ex)
            {
                ecr.MapException(ex);
            }
            ecr.IsSuccess = false;
            return (ecr, null, null);
        }

        public async Task<IAuthResponse> GenerateToken(User user, IAuthResponse authResponse)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            /*await InitalizeRoles();*/

            var role = _dataContext.Role.FirstOrDefault(r => r.Id == user.RoleId);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                     new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                     new Claim(ClaimTypes.Role, role.RoleName),
                 }),
                Expires = DateTime.UtcNow.AddSeconds(10),
                SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescriptor);

            authResponse.Map(new JwtSecurityTokenHandler().WriteToken(token),
                            token.ValidFrom.ToLocalTime(),
                            token.ValidTo.ToLocalTime(),

                            null,
                            DateTime.UtcNow,
                            DateTime.UtcNow);

            return authResponse;
            /*var refreshToken = new RefreshToken
            {
                JwtId = Guid.NewGuid().ToString(),
                IsUsed = false,
                IsInvalidated = false,
                UserId = user.Id,
                CreatedAt = DateTime.UtcNow,
                ExpireAt = DateTime.UtcNow.AddSeconds(15),
                Token = RandomString(35) + Guid.NewGuid()
            };

            await _dataContext.RefreshToken.AddAsync(refreshToken);
            await _dataContext.SaveChangesAsync();

            return new AuthResult
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                TokenCreatedAt = token.ValidFrom.ToLocalTime(),
                TokenExpireAt = token.ValidTo.ToLocalTime(),

                RefreshToken = refreshToken.Token,
                RefreshTokenCreatedAt = token.ValidFrom.ToLocalTime(),
                RefreshTokenExpireAt = token.ValidTo.ToLocalTime(),
            };*/
        }
    }
}
