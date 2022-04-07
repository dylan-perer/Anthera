using Anthera_API.Contracts;
using Anthera_API.Contracts.v1;
using Anthera_API.Models;

using System.Security.Claims;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public interface IIdentityService
    {
        public Task<(IAuthResponse, User)> signinAsync(IUserRequest signinRequest, IAuthResponse authResponse);
        public Task<(IAuthResponse, User)> SignupAsync(IUserRequest userRequest, IAuthResponse response);
        public void GetLoggedUser(in ClaimsPrincipal claimsPrincipal, out User user, out RoleEnum role);
        public Task<IAuthResponse> ValidateRefreshTokenAsync(string refreshTokenValue, IAuthResponse authResponse);
        public Task SignoutAsync(User loggedUser, string refreshToken);
    }
}
