using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
{
    public class UpdateSmokingRequest : IUserRequest
    {
        [EnsureSmoking]
        public string Smoking { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.SmokingId = DbConstant.StringToByte(Smoking, DbConstant.Smoking.AllSmokingTypes);
            return user;
        }
    }
}
