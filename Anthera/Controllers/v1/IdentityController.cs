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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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


        [HttpGet("ASS")]
        public  IActionResult fuck()
        {
            return Ok("FUK U");
        }
        [HttpPost(ApiRoutes.Identity.Signup)]
        public async Task<IActionResult> SignupAsync2([FromBody] SignupRequest signupRequest)
        {
            //check if password confirmation is valid.
            if (signupRequest.Password != signupRequest.ConfirmPassword)
            {
                return BadRequest(new { errors = AntheraConstant.Errors.Requests.ConfirmPasswordIsInvalid });
            }

            try
            {
                //do signup and generate jwt token and return it with IAuthResponse object.
                (var populatedAuthRes, var createdUser) = await _identityService.SignupAsync(signupRequest, new AuthResponse());
                IUserResponse res = new UserDetailsResponse().MapToResponse(createdUser);
                return Ok(new { user = (UserDetailsResponse)res, token = (AuthResponse)populatedAuthRes });

            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.Identity.ControllerV1, ApiRoutes.Identity.Signup, ApiRoutes.HTTP_ACTIONS.POST, signupRequest,
                                    out int statusCode,
                                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [HttpPost(ApiRoutes.Identity.Signin)]
        public async Task<IActionResult> SigninAsync([FromBody] SigninRequest signinRequest)
        {
            try
            {
                //check if user exists, if so, generate jwt token and return it with IAuthResponse object.
                (var populatedAuthRes, var existingUser) = await _identityService.signinAsync(signinRequest, new AuthResponse());

                IUserResponse res = new UserDetailsResponse().MapToResponse(existingUser);
                return Ok(new { user = (UserDetailsResponse)res, token = (AuthResponse)populatedAuthRes });
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.Identity.ControllerV1, ApiRoutes.Identity.Signin, ApiRoutes.HTTP_ACTIONS.POST, signinRequest,
                                    out int statusCode,
                                    out object msg);

                return StatusCode(statusCode, msg);
            }
        }

        [Authorize]
        [HttpPost(ApiRoutes.Identity.Signout)]
        public async Task<IActionResult> SignoutAsync([FromBody] SignoutRequest signoutRequest)
        {
            try
            {
                _identityService.GetLoggedUser(User, out User loggedUser, out RoleEnum role);
                await _identityService.SignoutAsync(loggedUser, signoutRequest.RefreshToken);
                return Ok(new { mesage = AntheraConstant.Requests.User.SignedoutSuccessfully });
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.Identity.ControllerV1, ApiRoutes.Identity.Signout, ApiRoutes.HTTP_ACTIONS.POST, signoutRequest,
                                    out int statusCode,
                                    out object msg);

                return StatusCode(statusCode, msg);
            }

        }

        [HttpPost(ApiRoutes.Identity.RefreshToken)]
        public async Task<ActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequest refreshTokenRequest)
        {
            try
            {
                var res = await _identityService.ValidateRefreshTokenAsync(refreshTokenRequest.RefreshToken, new AuthResponse());

                //send urer new token.
                return Ok(res);
            }
            catch (Exception ex)
            {
                new AntheraException().Error(ex, _logger, ApiRoutes.Identity.ControllerV1, ApiRoutes.Identity.RefreshToken, ApiRoutes.HTTP_ACTIONS.POST, 
                                    refreshTokenRequest,
                                    out int statusCode,
                                    out object msg);

                return StatusCode(statusCode, msg);
            }

        }

    }
}
