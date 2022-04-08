using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
{
    public class UpdateEducaltionLevel : IUserRequest
    {
        [EnsureRelationship]
        public string EducaltionLevel { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.EducationLevelId = DbConstant.StringToByte(EducaltionLevel, DbConstant.EducationLevel.AllEducationLevels);
            return user;
        }
    }
}
