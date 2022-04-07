using Anthera_API.Models;
using System;

namespace Anthera_API.Contracts.v1.Responses
{
    public class UserProfileResponse : IUserResponse
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime JoinedOn { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string City { get; set; }
        public string JobTitle { get; set; }
        public string CopmpanyName { get; set; }
        public string SchoolOrUniversity { get; set; }
        public string AboutMe { get; set; }
        public string Relationship { get; set; }
        public string Sexulaity { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string EyeColour { get; set; }
        public string HairColour { get; set; }
        public string Children { get; set; }
        public string Smoking { get; set; }
        public string Drinking { get; set; }
        public string HereTo { get; set; }
        public int PhotoLimit { get; set; }
        public string Religion { get; set; }
        public string EducationLevel { get; set; }
        public string Personality { get; set; }

        public IUserResponse MapToResponse(User user)
        {
            return new UserProfileResponse
            {
                Id = user.Id,
                Role = user.Role.RoleName,
                Name = user.Name,
                EmailAddress = user.EmailAddress,
                ProfilePictureUrl = user.ProfilePictureUrl,
                JoinedOn = user.CreatedAt,
                Gender = user.UserInfo.Gender.GenderName,
                Dob = user.UserInfo.Dob.ToLocalTime(),
                City = user.UserInfo.City,
                JobTitle = user.UserInfo.JobTitle.Title,
                CopmpanyName = user.UserInfo.CompanyName,
                SchoolOrUniversity = user.UserInfo.SchoolUniversity,
                AboutMe = user.UserInfo.AboutMe,
                Relationship = user.UserInfo.Relationship.RelationshipType,
                Sexulaity = user.UserInfo.Sexuality.SexualityType,
                Height = user.UserInfo.Height,
                Weight = user.UserInfo.Weight,
                EyeColour = user.UserInfo.EyeColour.Colour,
                HairColour = user.UserInfo.HairColour.Colour,
                Children = user.UserInfo.Children.ChildrenType,
                Smoking = user.UserInfo.Smoking.SmokingType,
                Drinking = user.UserInfo.Drinking.DrinkingType,
                HereTo = user.UserInfo.HereTo.HereToType,
                PhotoLimit = user.UserInfo.PhotoLimit,
                Religion = user.UserInfo.Religion.ReligionName,
                EducationLevel = user.UserInfo.EducationLevel.EducationLevelName,
                Personality = user.UserInfo.Personality.PersonalityName,

            };
        }

    }
}
