using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateAboutMeRequest : IUserRequest
    {
        [Required(AllowEmptyStrings =false)]
        [MaxLength(500)]
        public string AboutMe { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.AboutMe = AboutMe;
            return user;
        }
    }
}
