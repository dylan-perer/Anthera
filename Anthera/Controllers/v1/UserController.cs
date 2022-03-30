using Anthera_API.Data;
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
        private readonly DataContext _dataContext;
        private readonly ILogger<UserController> _logger;
        public UserController(DataContext dataContext, ILogger<UserController> logger)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Test()
        {
            _logger.LogError("ASSSSSSSSSSSSSSSSSSSSS");
            _logger.LogInformation("sssssssssASSSSSSSSSSSSSSSSSSSSS");
            return Ok("aa");
        }
    }
}
