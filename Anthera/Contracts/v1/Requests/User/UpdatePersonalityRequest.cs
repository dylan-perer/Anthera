using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdatePersonalityRequest : IUserRequest
    {
        [EnsureRelationship]
        public string Personality { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.PersonalityId = DbConstant.ConstantStringToIndexByte(Personality, DbConstant.Values.personality);
            return user;
        }
    }
}
