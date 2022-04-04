using Anthera_API.Models;
using DatabaseLookups;
using System;

namespace Anthera_API.Contracts.v1.Responses
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
            Gender = DbConstant.ConstantIndexToString(user.UserInfo.GenderId, DbConstant.Values.gender); 
            City = user.UserInfo.City;
            return this;
        }
    }
}
