using Anthera_API.Models_NEW;

namespace Anthera_API.Contracts.v1
{
    public interface IUserResponse
    {
        public IUserResponse MapToResponse(User user);
    }
}
