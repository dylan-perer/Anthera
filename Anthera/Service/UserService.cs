using Anthera_API.Data;
using Anthera_API.misc;
using Anthera_API.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;
        private ILogger _logger;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }
        public async Task<(ECResult, User)> CreateAsync(User user)
        {
            var ecr = new ECResult();
            try
            {
                user.CreatedAt = DateTime.UtcNow;
                user.LastOnline = DateTime.UtcNow;
                await _dataContext.User.AddAsync(user);
                await _dataContext.SaveChangesAsync();
                await InitializeUserInfo(user);
            }catch (Exception ex)
            {
                ecr.MapException(ex);
            }
            return (ecr, user);
        }

        public Task<(ECResult, User)> UpdateByIdAsync(User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ECResult> InitializeUserInfo(User user)
        {
            var ecr = new ECResult();
            try
            {
                var userInfo = new UserInfo
                {
                    UserId = user.Id,
                    GenderId = (int)GenderEnum.ID_PREFER_NOT_TO_SAY,
                    Dob = DateTime.UtcNow.AddYears(-21),
                    City = "Auckland",
                    IpAddress = null,
                    JobTitleId = (int)JobTitleEnum.ID_PREFER_NOT_TO_SAY,
                    CompanyName = ApiConstant.Db.ID_PREFER_NOT_TO_SAY,
                    SchoolUniversity = null,
                    AboutMe = ApiConstant.Db.ABOUT_ME_DEFAULT,
                    RelationshipId = (int)RelationshipEnum.ID_PREFER_NOT_TO_SAY,
                    SexualityId = (int)SexualityEnum.ID_PREFER_NOT_TO_SAY,
                    Height = ApiConstant.Db.HEIGHT_DEFAULT,
                    Weight = ApiConstant.Db.WEIGHT_DEFAULT,
                    EyeColourId = (int)EyeColourEnum.ID_PREFER_NOT_TO_SAY,
                    HairColourId = (int)HairyColourEnum.ID_PREFER_NOT_TO_SAY,
                    ChildrenId = (int)ChildrenEnum.ID_PREFER_NOT_TO_SAY,
                    SmokingId = (int)SmokingEnum.ID_PREFER_NOT_TO_SAY,
                    DrinkingId = (int)DrinkingEnum.ID_PREFER_NOT_TO_SAY,
                    HereToId = (int)HereToEnum.ID_PREFER_NOT_TO_SAY,
                    PhotoLimit = ApiConstant.Db.DEFAULT_PHOTO_LIMIT,
                };

                await _dataContext.UserInfo.AddAsync(userInfo);
                await _dataContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                ecr.MapException(ex);
            }
            return ecr;
        }
    }
}
