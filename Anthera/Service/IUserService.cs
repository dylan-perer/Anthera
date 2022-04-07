using Anthera_API.Contracts.v1;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Anthera_API.Service
{
    public interface IUserService
    {
        public User Create(IUserRequest userRequest, RoleEnum role = RoleEnum.ANTHERA_USER);
        public User GetUserById(int id);
        public User GetUserByEmail(string emailAddress);
        public UserInfo GetUserInfo(User user);
        public Task<User> UpdateUser(IUserRequest userRequest, User loggedUser);
        public User GetProfileDetails(User user);
        public Task UpdateProfilePicture(int id, string url);
        public Task AddPhotosAsync(User user, string[] urls);
        public Task<List<string>> GetPhotosAsync(User user);
        public Task<string> RemovePhotosAsync(User user, int photoId);
        public Task AddInterestAsync(User user, string[] interests);
        public Task RemoveInterestAsync(User user, int interestId);
        public Task<List<string>> GetInterestsAsync(User user);
        public Task AddLanguagesAsync(User user, string[] languages);
        public Task RemoveLanguageAsync(User user, int langaugeNameId);
        public Task<List<string>> GetLanguagesAsync(User user);
        public Task DeactivateAccount(User user, bool isToDeactivate);
    }
}
