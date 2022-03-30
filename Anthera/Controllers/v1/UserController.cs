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
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(DataContext dataContext, ILogger<UserController> logger, IUserService userService )
        {
            _logger = logger;
            _userService = userService;
            _userService.SetLogger( _logger );
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateUserRequest createUserRequest)
        {
            (var ecr, var createdUser) = await _userService.CreateAsync(createUserRequest.MapToModel());
            if (ecr.IsSuccess)
            {
                return Ok(new UserDetailsResponse().MapToResponse(createdUser));
            }
            return BadRequest(ApiConstant.Errors.GenericError);
        }
    }
}
