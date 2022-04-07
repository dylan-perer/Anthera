using Anthera_API.DataContext_NEW;
using Anthera_API.Models_NEW;

namespace Anthera_API.Contracts.v1.Responses
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
