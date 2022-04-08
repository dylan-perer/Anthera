using Anthera.API.Models;

namespace Anthera.API.Contracts.v1
{
    public interface IUserResponse
    {
        public IUserResponse MapToResponse(User user);
    }
}
