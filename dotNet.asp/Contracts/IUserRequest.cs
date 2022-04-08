using Anthera.API.Models;

namespace Anthera.API.Contracts.v1
{
    public interface IUserRequest
    {
        public User MapToModel(User user);
    }
}
