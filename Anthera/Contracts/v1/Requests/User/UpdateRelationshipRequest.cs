using Anthera_API.DataContext_NEW;
using Anthera_API.Models_NEW;
using Anthera_API.Validation;

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
