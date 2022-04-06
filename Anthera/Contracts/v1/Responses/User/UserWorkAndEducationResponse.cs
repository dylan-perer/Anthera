using Anthera_API.Models;
using DatabaseLookups;
using System;

namespace Anthera_API.Contracts.v1.Responses
{
    public class UserWorkAndEducationResponse : IUserResponse
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string SchoolOrUniversity { get; set; }

        public IUserResponse MapToResponse(User user)
        {
            JobTitle = DbInitializer.KeyToValueInt(user.UserInfo.JobTitleId, DbInitializer.Values.jobTitle);
            CompanyName = user.UserInfo.CompanyName;
            SchoolOrUniversity = user.UserInfo.SchoolUniversity;
            return this;
        }

    }
}
