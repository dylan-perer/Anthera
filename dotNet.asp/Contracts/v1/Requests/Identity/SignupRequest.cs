using Anthera.API.Contracts.v1;
using Anthera.API.Data;
using Anthera.API.Models;
using Anthera.API.Validation;

using System;
using System.ComponentModel.DataAnnotations;

namespace Anthera.API.Controllers.v1.Requests
{
    public class SignupRequest : IUserRequest
    {
        [Required]
        [MaxLength(14)]
        [MinLength(3)]
        public string Name { get; set; }

        [EnsureGender]
        public string Gender { get; set; }

        [EnsureSexPrefernce]
        public string SexPreference { get; set; }

        [EnsureHereTo]
        public string HereTo { get; set; }

        [EnusreDob]
        public DateTime Dob { get; set; }

        [MaxLength(255)]
        [EmailAddress]
        [EnsureUniqueEmail]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(6)]
        public string ConfirmPassword { get; set; }

        public User MapToModel(User user)
        {
            var genderId = (byte)DbConstant.StringToInt(Gender, DbConstant.Gender.AllGenders);

            var sexPreferenceId = (byte)DbConstant.StringToInt(SexPreference, DbConstant.PreferenceSex.AllPreferenceSexes);
            var preference = new Preference
            {
                PreferenceSexId = sexPreferenceId,
            };

            var hereToId = (byte)DbConstant.StringToInt(HereTo, DbConstant.HereTo.AllHereTotypes);

            var userInfo = new UserInfo();

            user.Name = Name;
            userInfo.GenderId = genderId;
            userInfo.Preference = preference;
            userInfo.HereToId = hereToId;
            userInfo.Dob = Dob;
            user.EmailAddress = EmailAddress;
            user.Password = Password;
            user.ProfilePictureUrl = null;
            user.RoleId = 1;

            user.UserInfo = userInfo;
            return user;
        }

        public override string ToString()
        {
            return $"Name: {Name}, EmailAddress: {EmailAddress}, Password: {Password}";
        }

    }

}
