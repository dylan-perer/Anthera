using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

namespace Anthera.API.Contracts.v1.Requests
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
