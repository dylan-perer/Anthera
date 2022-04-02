using Anthera_API.Contracts.v1;
using Anthera_API.Data;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public interface IUserService
    {
        public User Create(IUserRequest userRequest, RoleEnum role=RoleEnum.ANTHERA_USER);
        public Task<(ErrorResult, User)> UpdateByIdAsync(IUserRequest userRequest);
        public Task<(ErrorResult, User)> GetLoggedUserInfo(User user);


        /*   public Task<(ECResult, User)> UpdatePreferenceAsync(User user);

           public Task<(ECResult, User)> UpdateBasicAsync(User user);
           public Task<(ECResult, User)> UpdateWorkAndEducationAsync(User user);
           public Task<(ECResult, User)> UpdateHereToAsync(User user);
           public Task<(ECResult, User)> UpdateBioAsync(User user);


           public Task<(ECResult, User)> UpdateHeightAsync(User user);
           public Task<(ECResult, User)> UpdateChildrenAsync(User user);
           public Task<(ECResult, User)> UpdateDrinkingAsync(User user);
           public Task<(ECResult, User)> UpdateLanguageAsync(User user);
           public Task<(ECResult, User)> UpdateRelationshipStatusAsync(User user);
           public Task<(ECResult, User)> UpdateSexualityAsync(User user);
           public Task<(ECResult, User)> UpdateSmokingAsync(User user);
           public Task<(ECResult, User)> UpdateReligionAsync(User user);
           public Task<(ECResult, User)> UpdateEducationLevelAsync(User user);
           public Task<(ECResult, User)> UpdatePersonalityAsync(User user);


           public Task<(ECResult, User)> UpdateProfilePictureAsync(User user);
           public Task<(ECResult, User)> AddPhotosToGalleryAsync(User user);
           public Task<(ECResult, User)> DeletePhotosFromGalleryAsync(User user);*/

    }
}
