using Anthera.API.Data;
using Anthera.API.Models;

namespace Anthera.API.Contracts.v1.Responses
{
    public class UserWorkAndEducationResponse : IUserResponse
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string SchoolOrUniversity { get; set; }

        public IUserResponse MapToResponse(User user)
        {
            JobTitle = DbConstant.KeyToValueInt(user.UserInfo.JobTitleId, DbConstant.JobTitle.JobTitiles);
            CompanyName = user.UserInfo.CompanyName;
            SchoolOrUniversity = user.UserInfo.SchoolUniversity;
            return this;
        }

    }
}
