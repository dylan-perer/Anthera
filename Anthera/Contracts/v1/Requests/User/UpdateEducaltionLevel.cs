using Anthera_API.DELETE_Data;
using Anthera_API.DELETE_Models;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
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
