using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateDrinkingRequest : IUserRequest
    {
        [EnsureDrinking]
        public string Drinking { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.DrinkingId = DbInitializer.ConstantStringToIndexByte(Drinking, DbInitializer.Values.drinking);
            return user;
        }
    }
}
