using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateReligionRequest : IUserRequest
    {
        [EnsureRelationship]
        public string Religion { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.ReligionId = DbConstant.ConstantStringToIndexByte(Religion, DbConstant.Values.religion);
            return user;
        }
    }
}
