using Anthera_API.DELETE_Models;

using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateWeightRequest : IUserRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MaxLength(10)]
        public string Weight { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.Weight = Weight;
            return user;
        }
    }
}
