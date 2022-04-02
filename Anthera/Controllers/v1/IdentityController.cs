using Anthera_API.Contracts.v1.Requests;
using Anthera_API.Contracts.v1.Responses;
using Anthera_API.Controllers.v1.Requests;
using Anthera_API.Controllers.v1.Responses;
using Anthera_API.Data;
using Anthera_API.misc;
using Anthera_API.Models;
using Anthera_API.Models.Enums;
using Anthera_API.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Anthera_API.Controllers.v1
{
    [Route(ApiRoutes.Identity.ControllerV1)]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IIdentityService _identityService;
        public IdentityController(DataContext dataContext, ILogger<UserController> logger, IIdentityService identityService)
        {
            _logger = logger;
            _identityService = identityService;
        }

        [HttpPost(ApiRoutes.Identity.Signup)]
        public async Task<IActionResult> SignupAsync([FromBody] SignupRequest signupRequest)
        {
            //check if password confirmation is valid.
            if (signupRequest.Password != signupRequest.ConfirmPassword)
            {
                var _er = new ErrorResult
                {
                    EndUserError = ApiConstant.Errors.Requests.ConfirmPasswordIsInvalid
                };

                return BadRequest(_er.ReturnEndUserError());
            }

            //do signup and generate jwt token and return it with IAuthResponse object.
            (var er, var populatedAuthRes, var createdUser) = await _identityService.SignupAsync(signupRequest, new AuthResponse());
            if (er.IsSuccess)
            {
                return Ok(new { user = new UserDetailsResponse().MapToResponse(createdUser), token = (AuthResponse)populatedAuthRes });
            }

            //send client errors if present.
            if (er.SendClientError)
            {
                return BadRequest(er.ReturnEndUserError());
            }

            //log error to database.
            _logger.LogError(er.CreateLog(ApiRoutes.User.ControllerV1, ApiRoutes.HTTP_ACTIONS.POST, signupRequest));
            return BadRequest(ApiConstant.Errors.GenericError);
        }

        [HttpPost(ApiRoutes.Identity.Signin)]
        public async Task<IActionResult> SignupAsync([FromBody] SigninRequest signinRequest)
        {
            //check if user exists, if so, generate jwt token and return it with IAuthResponse object.
            (var er, var populatedAuthRes, var existingUser) = await _identityService.signinAsync(signinRequest, new AuthResponse());
            if (er.IsSuccess)
            {
                return Ok(new { user = new UserDetailsResponse().MapToResponse(existingUser), tokenData = (AuthResponse)populatedAuthRes });
            }

            //send client errors if present.
            else if (er.SendClientError)
            {
                return BadRequest(er.ReturnEndUserError());
            }

            //log error to database.
            _logger.LogError(er.CreateLog(ApiRoutes.User.ControllerV1, ApiRoutes.HTTP_ACTIONS.POST, signinRequest));
            return BadRequest(ApiConstant.Errors.GenericError);
        }

        [Authorize]
        [HttpPost(ApiRoutes.Identity.Signout)]
        public async Task<IActionResult> SignoutAsync([FromBody] SignoutRequest signoutRequest)
        {
            _identityService.GetLoggedUser(User, out User loggedUser, out RoleEnum role);
            var er = await _identityService.SignoutAsync(loggedUser, signoutRequest.RefreshToken);
            if (er.IsSuccess)
            {
                return Ok(ApiConstant.Requests.User.SignedoutSuccessfully);
            }

            //log error to database.
            _logger.LogError(er.CreateLog(ApiRoutes.User.ControllerV1, ApiRoutes.HTTP_ACTIONS.POST, signoutRequest));
            return BadRequest(ApiConstant.Errors.GenericError);
        }

        [HttpPost(ApiRoutes.Identity.RefreshToken)]
        public async Task<ActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequest refreshTokenRequest)
        {
            (var er, var res) = await _identityService.ValidateRefreshTokenAsync(refreshTokenRequest.RefreshToken, new AuthResponse());

            //on valid.
            if (er.IsSuccess)
            {
                return Ok(res);
            }
            var _er = new ErrorResult
            {
                EndUserError = ApiConstant.Errors.Requests.RefreshTokenIsInvalid
            };
            return BadRequest(_er.ReturnEndUserError());
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> bb()
        {
            _identityService.GetLoggedUser(User, out User loggedUser, out RoleEnum role);

            var a = new UserDetailsResponse().MapToResponse(loggedUser);
            return Ok(new { user = a, role = role });
        }
    }
}
