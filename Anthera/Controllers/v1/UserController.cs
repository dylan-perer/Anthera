using Anthera_API.Contracts.v1.Requests;
using Anthera_API.Controllers.v1.Requests;
using Anthera_API.Controllers.v1.Responses;
using Anthera_API.Data;
using Anthera_API.misc;
using Anthera_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Anthera_API.Controllers
{
    [Route(ApiRoutes.User.ControllerV1)]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(DataContext dataContext, ILogger<UserController> logger, IUserService userService )
        {
            _logger = logger;
            _userService = userService;
        }



        [HttpPut("basicinfo")]
        public async Task<IActionResult> UpdateBasicInfoAsync([FromBody]UpdateBasicInfoRequest updateBasicInfoRequest)
        {
            (var ecr, var updatedUser) = await _userService.UpdateByIdAsync(updateBasicInfoRequest);
            if (ecr.IsSuccess)
            {
                return Ok(new UserDetailsResponse().MapToResponse(updatedUser));
            }
            else if (ecr.SendClientError)
            {
                return BadRequest(ecr.EndUserError);
            }
            _logger.LogError(ecr.CreateLog(ApiRoutes.User.ControllerV1, ApiRoutes.HTTP_ACTIONS.PUT, updateBasicInfoRequest));
            return BadRequest(ApiConstant.Errors.GenericError);
        }
    }
}
