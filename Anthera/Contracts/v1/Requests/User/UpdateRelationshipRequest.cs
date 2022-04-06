using Anthera_API.Data;
using Anthera_API.Models;
using Anthera_API.Validation;

using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateRelationshipRequest : IUserRequest
    {
        [EnsureRelationship]
        public string Relationship { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.RelationshipId = DbConstant.StringToByte(Relationship, DbConstant.Relationship.AllRelationshipTypes);
            return user;
        }
    }
}
