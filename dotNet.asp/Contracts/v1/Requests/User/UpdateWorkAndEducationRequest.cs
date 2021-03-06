using Anthera.API.Contracts.v1;
using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Controllers.v1.Requests
{
    public class UpdateWorkAndEducationRequest : IUserRequest
    {
        [EnsureJobTitle]
        public string JobTitle { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string SchoolOrUniversity { get; set; }

        public User MapToModel(User user)
        {
            user.UserInfo.JobTitleId = DbConstant.StringToInt(JobTitle, DbConstant.JobTitle.JobTitiles);
            user.UserInfo.CompanyName = CompanyName;
            user.UserInfo.SchoolUniversity = SchoolOrUniversity;

            return user;
        }

        public override string ToString()
        {
            return $"JobTitle: {JobTitle}, CompanyName: {CompanyName}, SchoolOrUniversity: {SchoolOrUniversity}";
        }
    }
}
