using Anthera.API.Contracts.v1;
using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

using System;
using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Controllers.v1.Requests
{
    public class UpdateBasicInfoRequest : IUserRequest
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
            user.UserInfo.Dob = Dob;
            user.UserInfo.GenderId = (byte)DbConstant.StringToInt(Gender, DbConstant.Gender.AllGenders);
            return user;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Dob: {Dob}, Gender: {Gender}";
        }

    }
}
