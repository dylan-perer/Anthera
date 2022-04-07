﻿using Anthera_API.DataContext_NEW;
using Anthera_API.Models_NEW;
using Anthera_API.Validation;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateHereToRequest : IUserRequest
    {
        [EnsureHereTo]
        public string HereTo { get; set; }


        public User MapToModel(User user)
        {
            user.UserInfo.HereToId = DbConstant.StringToByte(HereTo, DbConstant.HereTo.AllHereTotypes);
            return user;
        }
    }
}
