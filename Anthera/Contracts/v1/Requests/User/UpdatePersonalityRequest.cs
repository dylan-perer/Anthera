using Anthera_API.DELETE_Data;
using Anthera_API.DELETE_Models;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdatePersonalityRequest : IUserRequest
    {
        [EnsureRelationship]
        public string Personality { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.PersonalityId = DbConstant.StringToByte(Personality, DbConstant.Personality.AllPersonalities);
            return user;
        }
    }
}
