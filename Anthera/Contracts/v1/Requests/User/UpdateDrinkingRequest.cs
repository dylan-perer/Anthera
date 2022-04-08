using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
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
