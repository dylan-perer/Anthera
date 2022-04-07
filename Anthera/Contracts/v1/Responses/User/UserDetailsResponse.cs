using Anthera_API.Contracts.v1;
using Anthera_API.Models_NEW;

namespace Anthera_API.Controllers.v1.Responses
{
    public class UserDetailsResponse : IUserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePictureUrl { get; set; }

        public IUserResponse MapToResponse(User user)
        {
            return new UserDetailsResponse
            {
                Id = user.Id,
                Name = user.Name,
                EmailAddress = user.EmailAddress,
                ProfilePictureUrl = ProfilePictureUrl,
            };
        }
    }
}
