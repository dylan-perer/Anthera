using Anthera_API.DELETE_Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Anthera_API.Service
{
    public class JwtTokenService
    {
        private readonly IConfiguration _configuration;
        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateAccessToken(User user, string roleName)
        {
            //defining claims.
            List<Claim> claims = new List<Claim>()
            {
                new Claim("id", user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.EmailAddress),
                new Claim(ClaimTypes.Role, roleName),
            };

            return GenerateToken(claims);
        }

        public string GenerateRefreshToken()
        {
            return GenerateToken();
        }

        private string GenerateToken(IEnumerable<Claim> claims = null)
        {
            //a type of key we used to sign and verify the token.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:AccessTokenSecret"]));

            var expire = DateTime.UtcNow.AddMinutes(Double.Parse(_configuration["Authentication:AccessTokenExpirationMinutes"]));

            //set refresh token config data.
            if (claims is null)
            {
                key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:RefreshTokenSecret"]));
                expire = DateTime.UtcNow.AddMinutes(Double.Parse(_configuration["Authentication:RefreshTokenExpirationMinutes"]));
            }

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //configure token settings.
            JwtSecurityToken token = new JwtSecurityToken(
                    _configuration["Authentication:Issuer"],//issurer
                    _configuration["Authentication:Audience"],//audience
                    claims,
                    DateTime.UtcNow, //from what point is the token valid
                    expire,//token expire
                    credentials);

            //convert the token into a string.
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool ValidateRefreshToken(string refreshToken, out DateTime expire)
        {
            var validationParameters = new TokenValidationParameters()
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:RefreshTokenSecret"])),

                ValidIssuer = _configuration["Authentication:Issuer"],
                ValidAudience = _configuration["Authentication:Audience"],

                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,

                ClockSkew = TimeSpan.Zero //makes sure token expires on set time.
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                tokenHandler.ValidateToken(refreshToken, validationParameters, out SecurityToken validatedToken);
                expire = validatedToken.ValidTo;
                return true;
            }
            catch
            {
                expire = DateTime.UtcNow;
                return false;
            }

        }
    }
}
