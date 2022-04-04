using Anthera_API.Controllers.v1;
using Anthera_API.Models;

namespace Anthera_API.Contracts.v1
{
    public interface IUserResponse
    {
        public IUserResponse MapToResponse(User user);
    }
}
