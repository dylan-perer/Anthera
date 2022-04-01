using Anthera_API.Contracts;
using Anthera_API.Contracts.v1;
using Anthera_API.Data;
using Anthera_API.Models;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public interface IIdentityService
    {
        public Task<(ECResult, User)> signin(IUserRequest userRequest);
        public Task<(ECResult, IAuthResponse, User)> SignupAsync(IUserRequest userRequest, IAuthResponse response);

    }
}
