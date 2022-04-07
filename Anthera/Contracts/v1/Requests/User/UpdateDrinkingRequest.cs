using Anthera_API.DELETE_Data;
using Anthera_API.DELETE_Models;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateDrinkingRequest : IUserRequest
    {
        [EnsureDrinking]
        public string Drinking { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.DrinkingId = DbConstant.StringToByte(Drinking, DbConstant.Drinking.AllDrinkingTypes);
            return user;
        }
    }
}
