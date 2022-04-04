using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateEducaltionLevel : IUserRequest
    {
        [EnsureRelationship]
        public string EducaltionLevel { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.EducationLevelId = DbConstant.ConstantStringToIndexByte(EducaltionLevel, DbConstant.Values.educationLevel);
            return user;
        }
    }
}
