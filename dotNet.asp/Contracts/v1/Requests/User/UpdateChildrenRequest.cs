using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
{
    public class UpdateChildrenRequest : IUserRequest
    {
        [EnsureChildren]
        public string Children { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.ChildrenId = DbConstant.StringToByte(Children, DbConstant.Children.AllChildrenTypes);
            return user;
        }
    }
}
