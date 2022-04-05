using Anthera_API.Contracts.v1;
using Anthera_API.Contracts.v1.Requests;
using Anthera_API.Data;
using Anthera_API.Extension;
using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using DatabaseLookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        public UserInfo GetUserInfo(User user)
        {
            var userInfo = _dataContext.UserInfo.FirstOrDefault(r => r.UserId == user.Id);
            if (userInfo is null)
            {
                throw new Exception("Sorry, no information about user was not found.");
            }

            return userInfo;
        }

        public User GetUserById(int id)
        {
            var user = _dataContext.User.FirstOrDefault(r => r.Id == id);
            if (user is null)
            {
                throw new AntheraException().Throw("Sorry, user does not exist.", 404);
            }

            return user;
        }

        public User GetUserByEmail(string emailAddress)
        {
            var user = _dataContext.User.FirstOrDefault(r => r.EmailAddress == emailAddress);
            if (user is null)
            {
                throw new AntheraException().Throw($"Sorry, '{emailAddress}' is not registerd. Please signup or try again.", 404);
            }

            return user;
        }

        public User Create(IUserRequest createUserRequest, RoleEnum role = RoleEnum.ANTHERA_USER)
        {
            try
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
            catch
            {
                throw new AntheraException().Throw("Failed to create user object", isDevError: true);
            }
        }

        public User GetProfileDetails(User loggedUser)
        {
            var user = GetUserById(loggedUser.Id);

            user.Role = new Role
            {
                RoleName = DbConstant.ConstantIndexToString(user.RoleId, DbConstant.Values.role)
            };

            var userInfo = GetUserInfo(user);

            user.UserInfo = userInfo;

            user.UserInfo.Gender = new Gender
            {
                GenderName = DbConstant.ConstantIndexToString(userInfo.GenderId, DbConstant.Values.gender)
            };

            user.UserInfo.JobTitle = new JobTitle
            {
                Title = DbConstant.ConstantIndexToString(userInfo.JobTitleId, DbConstant.Values.jobTitle)
            };

            user.UserInfo.Relationship = new Relationship
            {
                RelationshipType = DbConstant.ConstantIndexToString(userInfo.RelationshipId, DbConstant.Values.relationship)
            };

            user.UserInfo.Sexuality = new Sexuality
            {
                SexualityType = DbConstant.ConstantIndexToString(userInfo.SexualityId, DbConstant.Values.sexuality)
            };

            user.UserInfo.EyeColour = new EyeColour
            {
                Colour = DbConstant.ConstantIndexToString(userInfo.EyeColourId, DbConstant.Values.eyeColour)
            };

            user.UserInfo.HairColour = new HairColour
            {
                Colour = DbConstant.ConstantIndexToString(userInfo.HairColourId, DbConstant.Values.hairColour)
            };

            user.UserInfo.Children = new Children
            {
                ChildrenType = DbConstant.ConstantIndexToString(userInfo.ChildrenId, DbConstant.Values.children)
            };

            user.UserInfo.Smoking = new Smoking
            {
                SmokingType = DbConstant.ConstantIndexToString(userInfo.SmokingId, DbConstant.Values.smoking)
            };

            user.UserInfo.Drinking = new Drinking
            {
                DrinkingType = DbConstant.ConstantIndexToString(userInfo.DrinkingId, DbConstant.Values.drinking)
            };

            user.UserInfo.HereTo = new HereTo
            {
                HereToType = DbConstant.ConstantIndexToString(userInfo.HereToId, DbConstant.Values.hereTo)
            };

            user.UserInfo.Religion = new Religion
            {
                ReligionName = DbConstant.ConstantIndexToString(userInfo.ReligionId, DbConstant.Values.religion)
            };

            user.UserInfo.EducationLevel = new EducationLevel
            {
                EducationLevelName = DbConstant.ConstantIndexToString(userInfo.EducationLevelId, DbConstant.Values.educationLevel)
            };

            user.UserInfo.Personality = new Personality
            {
                PersonalityName = DbConstant.ConstantIndexToString(userInfo.PersonalityId, DbConstant.Values.personality)
            };
            return user;
        }

        private User InitializeUserInfo(User user)
        {
            user.UserInfo.Preference.AgeMin = 18;
            user.UserInfo.Preference.AgeMax = 69;
            user.UserInfo.Preference.Distance = 160;

            user.RoleId = DbConstant.ConstantStringToIndexByte(DbConstant.Values.Role.ANTHER_USER, DbConstant.Values.role);
            user.UserInfo.UserId = user.Id;
            user.UserInfo.City = "Auckland";
            user.UserInfo.IpAddress = null;
            user.UserInfo.JobTitleId = DbConstant.DefaultValue(DbConstant.Values.jobTitle);
            user.UserInfo.CompanyName = DbConstant.Values.PREFER_NOT_TO_SAY_DFAULT;
            user.UserInfo.SchoolUniversity = DbConstant.Values.PREFER_NOT_TO_SAY_DFAULT;
            user.UserInfo.AboutMe = DbConstant.Values.ABOUT_ME_DEFAULT;
            user.UserInfo.RelationshipId = DbConstant.DefaultValue(DbConstant.Values.relationship);
            user.UserInfo.SexualityId = DbConstant.DefaultValue(DbConstant.Values.sexuality);
            user.UserInfo.Height = DbConstant.Values.HEIGHT_DEFAULT;
            user.UserInfo.Weight = DbConstant.Values.WEIGHT_DEFAULT;
            user.UserInfo.EyeColourId = DbConstant.DefaultValue(DbConstant.Values.eyeColour);
            user.UserInfo.HairColourId = DbConstant.DefaultValue(DbConstant.Values.hairColour);
            user.UserInfo.ChildrenId = DbConstant.DefaultValue(DbConstant.Values.children);
            user.UserInfo.SmokingId = DbConstant.DefaultValue(DbConstant.Values.smoking);
            user.UserInfo.DrinkingId = DbConstant.DefaultValue(DbConstant.Values.drinking);
            user.UserInfo.PhotoLimit = DbConstant.Values.DEFAULT_PHOTO_LIMIT;
            user.UserInfo.EducationLevelId = DbConstant.DefaultValue(DbConstant.Values.educationLevel);
            user.UserInfo.PersonalityId = DbConstant.DefaultValue(DbConstant.Values.personality);
            user.UserInfo.ReligionId = DbConstant.DefaultValue(DbConstant.Values.religion);

            return user;
        }

        public async Task<User> UpdateUser(IUserRequest userRequest, User loggedUser)
        {
            var user = GetUserById(loggedUser.Id);
            var userInfo = GetUserInfo(user);

            try
            {
                user.UserInfo = userInfo;

                //maps what needs to be updated to user object.
                userRequest.MapToModel(user);

                //update db.
                _dataContext.User.Update(user);
                await _dataContext.SaveChangesAsync();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong updating user. Please try again.");
            }
            return user;
        }

        public async Task UpdateProfilePicture(int id, string url)
        {
            var user = GetUserById(id);

            try
            {
                user.ProfilePictureUrl = url;
                _dataContext.Update(user);
                await _dataContext.SaveChangesAsync();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong updating profile picture. Please try again.");
            }
        }

        public async Task AddPhotosAsync(User user, string[] urls)
        {
            user = GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var userInfoPhotos = await _dataContext.UserInfoPhoto.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();

            if (userInfoPhotos.Count >= userInfo.PhotoLimit)
            {
                throw new AntheraException().Throw("Sorry, you have reached your photo limt. To add more please upgrade subscription.", 402);
            }

            try
            {
                await _dataContext.Database.BeginTransactionAsync();

                foreach (var url in urls)
                {
                    var photo = new Photo { PhotoUrl = url };
                    await _dataContext.Photo.AddAsync(photo);
                    await _dataContext.SaveChangesAsync();

                    var userInfoPhoto = new UserInfoPhoto { UserInfoId = userInfo.Id, PhotoId = photo.Id };
                    await _dataContext.UserInfoPhoto.AddAsync(userInfoPhoto);
                    await _dataContext.SaveChangesAsync();
                }

                _dataContext.Database.CommitTransaction();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong adding your photos. Please try again.");
            }

        }
        public async Task<string> RemovePhotosAsync(User user, int photoId)
        {
            user = GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var photo = _dataContext.Photo.FirstOrDefault(r => r.Id == photoId);
            if (photo is null)
            {
                throw new AntheraException().Throw("Photo does not exist.", 400);
            }

            var userInfoPhotos = await _dataContext.UserInfoPhoto.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();
            if (userInfoPhotos.Count == 0)
            {
                throw new AntheraException().Throw("You don't have any photos to delete.", 400);
            }

            try
            {
                foreach (var item in userInfoPhotos)
                {
                    if (item.PhotoId == photoId)
                    {
                        _dataContext.UserInfoPhoto.Remove(item);
                        _dataContext.Photo.Remove(photo);
                        break;
                    }
                }
                await _dataContext.SaveChangesAsync();
                return photo.PhotoUrl;
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong removing your photo. Please try again.");
            }

        }
        public async Task<List<string>> GetPhotosAsync(User user)
        {
            GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var userInfoPhotos = await _dataContext.UserInfoPhoto.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();
            if (userInfoPhotos.Count == 0)
            {
                throw new AntheraException().Throw("You have no photos.");

            }

            try
            {
                var list = new List<string>();

                foreach (var x in userInfoPhotos)
                {
                    list.Add(_dataContext.Photo.FirstOrDefault(r => r.Id == x.PhotoId).PhotoUrl);
                }
                return list;
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong retrieving your photos. Please try again.");
            }
        }


        public async Task AddInterestAsync(User user, string[] interests)
        {
            user = GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var userInfoInterests = await _dataContext.UserInfoInterests.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();

            if (userInfoInterests.Count >= DbConstant.Values.INTEREST_LIMIT)
            {
                throw new AntheraException().Throw("Sorry, you can only have 25 interest at a time. Please remove some to add more.");
            }

            try
            {
                await _dataContext.Database.BeginTransactionAsync();

                foreach (var interestType in interests)
                {
                    var interest = new Interests { InterestType = interestType };
                    await _dataContext.Interests.AddAsync(interest);
                    await _dataContext.SaveChangesAsync();

                    var userInfoIntrest = new UserInfoInterests { UserInfoId = userInfo.Id, InterestsId = interest.Id };
                    await _dataContext.UserInfoInterests.AddAsync(userInfoIntrest);
                    await _dataContext.SaveChangesAsync();
                }

                _dataContext.Database.CommitTransaction();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong adding your interests. Please try again.");
            }

        }
        public async Task RemoveInterestAsync(User user, int interestId)
        {
            user = GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var interest = _dataContext.Interests.FirstOrDefault(r => r.Id == interestId);
            if (interest is null)
            {
                throw new AntheraException().Throw("Interest does not exist.", 400);
            }

            var userInfoInterests = await _dataContext.UserInfoInterests.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();
            if (userInfoInterests.Count == 0)
            {
                throw new AntheraException().Throw("You don't have any interests to remove.", 400);
            }

            try
            {
                foreach (var item in userInfoInterests)
                {
                    if (item.InterestsId == interestId)
                    {
                        _dataContext.UserInfoInterests.Remove(item);
                        _dataContext.Interests.Remove(interest);
                        break;
                    }
                }
                await _dataContext.SaveChangesAsync();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong removing your interest. Please try again.");
            }

        }
        public async Task<List<string>> GetInterestsAsync(User user)
        {
            GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var userInfoInterests = await _dataContext.UserInfoInterests.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();
            if (userInfoInterests.Count == 0)
            {
                throw new AntheraException().Throw("You have no interests.");

            }

            try
            {
                var list = new List<string>();

                foreach (var x in userInfoInterests)
                {
                    list.Add(_dataContext.Interests.FirstOrDefault(r => r.Id == x.InterestsId).InterestType);
                }
                return list;
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong retrieving your interests. Please try again.");
            }
        }


        public async Task AddLanguagesAsync(User user, string[] languages)
        {
            user = GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var userInfoLanguages = await _dataContext.UserInfoLanguage.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();

            if (userInfoLanguages.Count >= 8)
            {
                throw new AntheraException().Throw("Sorry, you can't add any more languages. Please remove some to add more.");
            }

            try
            {
                await _dataContext.Database.BeginTransactionAsync();

                foreach (var languageName in languages)
                {
                    var language = new Language { LanguageName = languageName };
                    await _dataContext.Language.AddAsync(language);
                    await _dataContext.SaveChangesAsync();

                    var userInfoLanguage = new UserInfoLanguage { UserInfoId = userInfo.Id, LanguageId = language.Id };
                    await _dataContext.UserInfoLanguage.AddAsync(userInfoLanguage);
                    await _dataContext.SaveChangesAsync();
                }

                _dataContext.Database.CommitTransaction();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong adding your langauge. Please try again.");
            }

        }
        public async Task RemoveLanguageAsync(User user, int langaugeNameId)
        {
            user = GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var langauge = _dataContext.Language.FirstOrDefault(r => r.Id == langaugeNameId);
            if (langauge is null)
            {
                throw new AntheraException().Throw("Language does not exist.", 400);
            }

            var userInfoLanguage = await _dataContext.UserInfoLanguage.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();
            if (userInfoLanguage.Count == 0)
            {
                throw new AntheraException().Throw("You don't have any langauges to remove.", 400);
            }

            try
            {
                foreach (var item in userInfoLanguage)
                {
                    if (item.LanguageId == langaugeNameId)
                    {
                        _dataContext.UserInfoLanguage.Remove(item);
                        _dataContext.Language.Remove(langauge);
                        break;
                    }
                }
                await _dataContext.SaveChangesAsync();
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong removing langauge. Please try again.");
            }

        }
        public async Task<List<string>> GetLanguagesAsync(User user)
        {
            GetUserById(user.Id);
            var userInfo = GetUserInfo(user);

            var userInfoLanguage = await _dataContext.UserInfoLanguage.Where(r => r.UserInfoId == userInfo.Id).ToListAsync();
            if (userInfoLanguage.Count == 0)
            {
                throw new AntheraException().Throw("You dont have any langauges added.");

            }

            try
            {
                var list = new List<string>();

                foreach (var x in userInfoLanguage)
                {
                    list.Add(_dataContext.Language.FirstOrDefault(r => r.Id == x.LanguageId).LanguageName);
                }
                return list;
            }
            catch
            {
                throw new AntheraException().Throw("Sorry, something went wrong retrieving your interests. Please try again.");
            }
        }

        public async Task DeactivateAccount(User user, bool isToDeactivate)
        {
            user = GetUserById(user.Id);

            try
            {
                user.IsDeactivated = !user.IsDeactivated;
                _dataContext.User.Update(user);
                await _dataContext.SaveChangesAsync();
            }
            catch
            {
                if (isToDeactivate)
                    throw new AntheraException().Throw("Sorry, soemthing went wrong deactivating your account.");
                throw new AntheraException().Throw("Sorry, soemthing went wrong reactivating your account account.");
            }


        }
    }
}
