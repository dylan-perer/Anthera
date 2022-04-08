using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
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
