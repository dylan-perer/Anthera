using Anthera_API.Contracts.v1;
using Anthera_API.Contracts.v1.Requests;
using Anthera_API.Contracts.v1.Responses;
using Anthera_API.Controllers.v1.Requests;
using Anthera_API.Controllers.v1.Responses;
using Anthera_API.Data;
using Anthera_API.Extension;
using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using Anthera_API.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Anthera_API.Controllers
{
    [Route(ApiRoutes.User.ControllerV1)]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IIdentityService _identityService;
        private readonly IUserService _userService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(ILogger<UserController> logger, IIdentityService identityService, IUserService userService, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _identityService = identityService;
            _userService = userService;
            _webHostEnvironment = webHostEnvironment;
        }
        private async Task UpdateSingleUserInfo(IUserRequest request)
        {
            _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
            //update db.
            await _userService.UpdateUser(request, user);
        }

        [Authorize]
        [HttpGet(ApiRoutes.User.Profile)]
        public IActionResult Profile()
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                user = _userService.GetProfileDetails(user);
                return Ok(new UserProfileResponse().MapToResponse(user));
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Profile, ApiRoutes.HTTP_ACTIONS.GET,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }


        [Authorize]
        [HttpPut(ApiRoutes.User.Basicinfo)]
        public async Task<IActionResult> UpdateBasicInfoAsync([FromBody] UpdateBasicInfoRequest updateBasicInfoRequest)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                var updatedUser = await _userService.UpdateUser(updateBasicInfoRequest, user);
                return Ok(new UserBasicInfoResponse().MapToResponse(user));
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Children, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateBasicInfoRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Children)]
        public async Task<IActionResult> UpdateChildrenAsync([FromBody] UpdateChildrenRequest updateChildrenRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateChildrenRequest);
                return Ok(updateChildrenRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Children, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateChildrenRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Drinking)]
        public async Task<IActionResult> UpdateDrinkingAsync([FromBody] UpdateDrinkingRequest updateDrinkingRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateDrinkingRequest);
                return Ok(updateDrinkingRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Drinking, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateDrinkingRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Smoking)]
        public async Task<IActionResult> UpdateDrinkingAsync([FromBody] UpdateSmokingRequest updateSmokingRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateSmokingRequest);
                return Ok(updateSmokingRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Smoking, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateSmokingRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.WorkAndEducation)]
        public async Task<IActionResult> UpdateWorkAndEducationAsync([FromBody] UpdateWorkAndEducationRequest updateWorkAndEducationRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateWorkAndEducationRequest);
                return Ok(updateWorkAndEducationRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.WorkAndEducation, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateWorkAndEducationRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Height)]
        public async Task<IActionResult> UpdateHeightAsync([FromBody] UpdateHeightRequest updateHeightRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateHeightRequest);
                return Ok(updateHeightRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Height, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateHeightRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.HereTo)]
        public async Task<IActionResult> UpdateHereToAsync([FromBody] UpdateHereToRequest updateHereToRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateHereToRequest);
                return Ok(updateHereToRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.HereTo, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateHereToRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Personality)]
        public async Task<IActionResult> UpdatePersonalityAsync([FromBody] UpdatePersonalityRequest updatePersonalityRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updatePersonalityRequest);
                return Ok(updatePersonalityRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Personality, ApiRoutes.HTTP_ACTIONS.PUT,
                    updatePersonalityRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Relationship)]
        public async Task<IActionResult> UpdateRelationshipAsync([FromBody] UpdateRelationshipRequest updateRelationshipRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateRelationshipRequest);
                return Ok(updateRelationshipRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Relationship, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateRelationshipRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Religion)]
        public async Task<IActionResult> UpdateReligionAsync([FromBody] UpdateReligionRequest updateReligionRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateReligionRequest);
                return Ok(updateReligionRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Religion, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateReligionRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.Weight)]
        public async Task<IActionResult> UpdateWeightAsync([FromBody] UpdateWeightRequest updateWeightRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateWeightRequest);
                return Ok(updateWeightRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.Weight, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateWeightRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.AboutMe)]
        public async Task<IActionResult> UpdateAboutMeAsync([FromBody] UpdateAboutMeRequest updateAboutMeRequest)
        {
            try
            {
                await UpdateSingleUserInfo(updateAboutMeRequest);
                return Ok(updateAboutMeRequest);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateAboutMeRequest,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPut(ApiRoutes.User.EducationLevel)]
        public async Task<IActionResult> UpdateEducationLevelAsync([FromBody] UpdateEducaltionLevel updateEducaltionLevel)
        {
            try
            {
                await UpdateSingleUserInfo(updateEducaltionLevel);
                return Ok(updateEducaltionLevel);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    updateEducaltionLevel,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPost(ApiRoutes.User.Gallery)]
        public async Task<IActionResult> AddToPhotosAsync(List<IFormFile> files)
        {
            if (files.Count == 0)
            {
                return BadRequest(new { errors = "No file sent." });
            }

            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);

                string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, @"UploadedFiles/img");
                List<string> urls = new List<string>();
                foreach (var file in files)
                {
                    var fileName = SaveFileOnServer(file);
                    urls.Add(fileName);
                }
                await _userService.AddPhotosAsync(user, urls.ToArray());
                return Ok(new { message = "Upload successful." });
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPost(ApiRoutes.User.ProfilePicture)]
        public async Task<IActionResult> UpdateProfilePictureAsync(IFormFile file)
        {
            if (file is null)
            {
                return BadRequest(new { errors = "No file sent." });
            }

            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);

                var existingProfilePictureName = _userService.GetUserById(user.Id).ProfilePictureUrl;

                string fileName = SaveFileOnServer(file, existingProfilePictureName);

                await _userService.UpdateProfilePicture(user.Id, fileName);
                return Ok(new { message = "Upload successful." });
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }

        }
        [Authorize]
        [HttpGet(ApiRoutes.User.Gallery)]
        public async Task<IActionResult> GetPhotosAsync()
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                return Ok(await _userService.GetPhotosAsync(user));

            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpDelete(ApiRoutes.User.Gallery+"/{photoId}")]
        public async Task<IActionResult> DeletePhotoAsync([FromRoute]int photoId)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                DeleteFileFromServer(await _userService.RemovePhotosAsync(user, photoId));
                return Ok();
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPost("interest")]
        public async Task<IActionResult> AddInterestAsync([FromRoute] string[] interests)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                await _userService.AddInterestAsync(user, interests);
                return Ok(interests);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpGet("interest")]
        public async Task<IActionResult> GetInterestsAsync()
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                return Ok(await _userService.GetInterestsAsync(user));
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpDelete("interest")]
        public async Task<IActionResult> RemoveInterest([FromRoute] int interestId)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                await _userService.RemoveInterestAsync(user, interestId);
                return Ok();
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPost("language")]
        public async Task<IActionResult> AddLangugeAsync([FromRoute] string[] langauges)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                await _userService.AddLanguagesAsync(user, langauges);
                return Ok(langauges);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpGet("language")]
        public async Task<IActionResult> GetLangugesAsync()
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                return Ok(await _userService.GetLanguagesAsync(user));
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpDelete("language")]
        public async Task<IActionResult> RemoveLanguageAsync([FromRoute] int languageNameId)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User user, out RoleEnum role);
                await _userService.RemoveLanguageAsync(user, languageNameId);
                return Ok();
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.User.ControllerV1, ApiRoutes.User.AboutMe, ApiRoutes.HTTP_ACTIONS.PUT,
                    null,
                    out int statusCode,
                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        private bool DeleteFileFromServer(string fileName)
        {
            try
            {
                string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, @"UploadedFiles/img");
                directoryPath += "/" + fileName;

                if ((System.IO.File.Exists(directoryPath)))
                {
                    System.IO.File.Delete(directoryPath);
                    return true;
                }
                return false;
            }
            catch
            {
                throw new AntheraException().Throw("Failed to delete file from server", isDevError: true);
            }
        }

        private string SaveFileOnServer(IFormFile file, string fileName=null)
        {
            string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, @"UploadedFiles/img");
            AntheraMisc.ValidateFile(file);

            if(fileName == null)
            {
                fileName = Guid.NewGuid() + file.FileName;
            }

            //write file into sattic folder.
            var filePath = Path.Combine(directoryPath, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            };
            return fileName;
        }

        
    }
}
