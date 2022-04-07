using Anthera_API.DELETE_Models;

namespace Anthera_API.Contracts.v1
{
    public interface IUserResponse
    {
        public IUserResponse MapToResponse(User user);
    }
}
