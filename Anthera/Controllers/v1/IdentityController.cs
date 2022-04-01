using Anthera_API.Contracts.v1.Responses;
using Anthera_API.Controllers.v1.Requests;
using Anthera_API.Controllers.v1.Responses;
using Anthera_API.Data;
using Anthera_API.misc;
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

        [HttpPost]
        public async Task<IActionResult> SignupAsync([FromBody] CreateUserRequest createUserRequest)
        {
            (var ecr, var populatedAuthRes, var createdUser) = await _identityService.SignupAsync(createUserRequest, new AuthResponse());
            if (ecr.IsSuccess)
            {
                var obj = new { user = new UserDetailsResponse().MapToResponse(createdUser), tokenData = (AuthResponse)populatedAuthRes};
                return Ok(obj);
            }
            else if (ecr.SendClientError)
            {
                return BadRequest(ecr.EndUserError);
            }
            _logger.LogError(ecr.CreateLog(ApiRoutes.User.ControllerV1, ApiRoutes.HTTP_ACTIONS.POST, createUserRequest));
            return BadRequest(ApiConstant.Errors.GenericError);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> bb()
        {
            return Ok("AUTHORIZEDDD");
        }
    }
}
