using Anthera_API.Models;

namespace Anthera_API.Controllers.v1.Responses
{
    public class UserDetailsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePictureUrl { get; set; }

        public UserDetailsResponse MapToResponse(User user)
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
