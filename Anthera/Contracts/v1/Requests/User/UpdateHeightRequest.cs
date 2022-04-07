using Anthera_API.DELETE_Models;

using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateHeightRequest : IUserRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(10)]
        public string Height { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.Height = Height;
            return user;
        }
    }
}
