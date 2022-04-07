﻿using Anthera_API.DELETE_Data;
using Anthera_API.DELETE_Models;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
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
