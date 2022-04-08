using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
{
    public class UpdateReligionRequest : IUserRequest
    {
        [EnsureRelationship]
        public string Religion { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.ReligionId = DbConstant.StringToByte(Religion, DbConstant.Religion.Religions);
            return user;
        }
    }
}
