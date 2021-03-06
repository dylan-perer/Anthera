using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
{
    public class UpdateHereToRequest : IUserRequest
    {
        [EnsureHereTo]
        public string HereTo { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.HereToId = DbConstant.StringToByte(HereTo, DbConstant.HereTo.AllHereTotypes);
            return user;
        }
    }
}
