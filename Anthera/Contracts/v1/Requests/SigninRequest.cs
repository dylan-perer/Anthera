using Anthera_API.Models;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class SigninRequest : Request, IUserRequest
    {
        [MaxLength(255)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(6)]
        public string Password { get; set; }

        public User MapToModel(User user)
        {
            user.EmailAddress = EmailAddress;
            user.Password = Password;
            return user;
        }
    }
}
