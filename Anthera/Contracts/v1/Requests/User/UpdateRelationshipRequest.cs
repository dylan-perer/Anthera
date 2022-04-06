using Anthera_API.Models;
using Anthera_API.Validation;
using DatabaseLookups;
using System.ComponentModel.DataAnnotations;

namespace Anthera_API.Contracts.v1.Requests
{
    public class UpdateRelationshipRequest : IUserRequest
    {
        [EnsureRelationship]
        public string Relationship { get; set; }
        
        
        public User MapToModel(User user)
        {
            user.UserInfo.RelationshipId = DbInitializer.ConstantStringToIndexByte(Relationship, DbInitializer.Values.relationship);
            return user;
        }
    }
}
