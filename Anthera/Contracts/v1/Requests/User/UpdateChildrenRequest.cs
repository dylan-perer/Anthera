using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateChildrenRequest : IUserRequest
    {
        [EnsureChildren]
        public string Children { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.ChildrenId = DbConstant.ConstantStringToIndexByte(Children,DbConstant.Values.children);
            return user;
        }
    }
}
