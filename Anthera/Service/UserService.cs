using Anthera_API.Contracts.v1;
using Anthera_API.Contracts.v1.Requests;
using Anthera_API.Data;
using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public User Create(IUserRequest createUserRequest, RoleEnum role = RoleEnum.ANTHERA_USER)
        {
            User user = new User();

            //map request to model
            createUserRequest.MapToModel(user);

            //asign user role
            if (role != RoleEnum.ANTHERA_USER)
            {
                user.RoleId = (byte)role;
            }

            user.CreatedAt = DateTime.UtcNow;
            user.LastOnline = DateTime.UtcNow;
            InitializeUserInfo(user);
            return user;
        }

        public User InitializeUserInfo(User user)
        {
            var ecr = new ECResult();
            try
            {
                user.UserInfo.Preference.AgeMin = 18;
                user.UserInfo.Preference.AgeMax = 69;
                user.UserInfo.Preference.Distance = 160;

                user.UserInfo.UserId = user.Id;
                user.UserInfo.City = "Auckland";
                user.UserInfo.IpAddress = null;
                user.UserInfo.JobTitleId = (int)JobTitleEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.CompanyName = ApiConstant.Db.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.SchoolUniversity = ApiConstant.Db.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.AboutMe = ApiConstant.Db.ABOUT_ME_DEFAULT;
                user.UserInfo.RelationshipId = (int)RelationshipEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.SexualityId = (int)SexualityEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.Height = ApiConstant.Db.HEIGHT_DEFAULT;
                user.UserInfo.Weight = ApiConstant.Db.WEIGHT_DEFAULT;
                user.UserInfo.EyeColourId = (int)EyeColourEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.HairColourId = (int)HairyColourEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.ChildrenId = (int)ChildrenEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.SmokingId = (int)SmokingEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.DrinkingId = (int)DrinkingEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.PhotoLimit = ApiConstant.Db.DEFAULT_PHOTO_LIMIT;
                user.UserInfo.EducationLevelId = (int)EducationLevelEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.PersonalityId = (int)PersonalityEnum.ID_PREFER_NOT_TO_SAY;
                user.UserInfo.ReligionId = (int)ReligionEnum.ID_PREFER_NOT_TO_SAY;

            }
            catch (Exception ex)
            {
                ecr.MapException(ex);
            }
            return user;
        }

        public async Task<(ECResult, User)> UpdateByIdAsync(IUserRequest userRequest)
        {
            var ecr = new ECResult();
            User user = null;
            try
            {
                //get logged user
                user = _dataContext.User.SingleOrDefault(r => r.Id == 1);
                var userInfo = _dataContext.UserInfo.SingleOrDefault(r => r.UserId == 1);
                var preference = _dataContext.Preference.SingleOrDefault(r => r.Id == userInfo.PreferenceId);

                user.UserInfo = userInfo;
                user.UserInfo.Preference = preference;

                userRequest.MapToModel(user);
                user.LastOnline = DateTime.UtcNow;
                _dataContext.User.Update(user);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ecr.MapException(ex);
            }
            return (ecr, user);
        }


    }
}
