using Anthera_API.Contracts.v1;
using Anthera_API.Data;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Security.Claims;
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
        public Task AddToGallery(User user, string[] urls);
        public Task<List<string>> GetUserGalleryAsync(User user);
        public Task<string> RemoveFromGallery(User user, int photoId);
    }
}
