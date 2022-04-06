using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateHereToRequest : IUserRequest
    {
        [EnsureHereTo]
        public string HereTo { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.HereToId = DbInitializer.ConstantStringToIndexByte(HereTo, DbInitializer.Values.hereTo);
            return user;
        }
    }
}
