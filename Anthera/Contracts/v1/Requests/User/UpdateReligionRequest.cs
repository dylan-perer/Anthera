using Anthera_API.Data;
using Anthera_API.Models;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
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
