using Anthera_API.Data;
using Anthera_API.Models;
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
