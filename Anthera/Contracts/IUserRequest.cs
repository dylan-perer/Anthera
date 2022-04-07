using Anthera_API.Models;

namespace Anthera_API.Contracts.v1
{
    public interface IUserRequest
    {
        public User MapToModel(User user);
    }
}
