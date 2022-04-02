using Anthera_API.Data;
using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
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
            user.UserInfo.GenderId = (byte)DatbaseConstants.StringToByte(Gender, DatbaseConstants.Values.gender);
            return user;
        }
    }
}
