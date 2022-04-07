using Anthera_API.DataContext_NEW;
using Anthera_API.Models_NEW;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
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
