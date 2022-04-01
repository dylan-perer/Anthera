using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateBasicInfoRequest : Request, IUserRequest
    {
        [Required]
        public string Name { get; set; }
        [EnusreDob]
        public DateTime Dob { get; set; }
        [EnsureGender]
        public string Gender { get; set; }

        public User MapToModel(User user)
        {
            user.Name = Name;
            user.UserInfo.Dob= Dob;
            user.UserInfo.GenderId = (byte)StringToByte(Gender, ApiConstant.Requests.ValidValues.User.GENDERS);
            return user;
        }
    }
}
