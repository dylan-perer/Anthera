using Anthera.API.Data;
using Anthera.API.Models;

using System;

namespace Anthera.API.Contracts.v1.Responses
{
    public class UserBasicInfoResponse : IUserResponse
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        public IUserResponse MapToResponse(User user)
        {
            Name = user.Name;
            Dob = user.UserInfo.Dob;
            Gender = DbConstant.KeyToValueByte(user.UserInfo.GenderId, DbConstant.Gender.AllGenders);
            City = user.UserInfo.City;
            return this;
        }
    }
}
