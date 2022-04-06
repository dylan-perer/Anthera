using Anthera_API.Contracts.v1;
using Anthera_API.Contracts.v1.Requests;
using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Controllers.v1.Requests
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
            user.UserInfo.GenderId = (byte)DbInitializer.ConstantStringToIndex(Gender, DbInitializer.Values.gender);
            return user;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Dob: {Dob}, Gender: {Gender}";
        }

    }
}
