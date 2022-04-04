using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateSmokingRequest : IUserRequest
    {
        [EnsureSmoking]
        public string Smoking { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.SmokingId = DbConstant.ConstantStringToIndexByte(Smoking, DbConstant.Values.smoking);
            return user;
        }
    }
}
