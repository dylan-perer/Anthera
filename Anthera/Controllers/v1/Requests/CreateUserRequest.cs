using Anthera_API.Models;
using System;

namespace Anthera_API.Controllers.v1.Requests
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ProfilePictureUrl { get; set; }
    
        public User MapToModel()
        {
            return new User
            {
                Name = Name,
                EmailAddress = EmailAddress,
                Password = Password,
                ProfilePictureUrl = ProfilePictureUrl,
            };
        }
    }

}
