using Anthera.API.Contracts.v1;
using Anthera.API.Models;
using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Controllers.v1.Requests
{
    public class SigninRequest : IUserRequest
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

        public override string ToString()
        {
            return $"EmailAddress: {EmailAddress}, Password: {Password}";
        }
    }
}
