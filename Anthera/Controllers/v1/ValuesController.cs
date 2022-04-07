using Anthera_API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Anthera_API.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DatabaseConstantService _databaseConstantService;
        public ValuesController(DatabaseConstantService databaseConstantService)
        {
            _databaseConstantService = databaseConstantService;
        }

        [HttpGet("InitDbConstants")]
        public IActionResult InitDatabaseConstants()
        {
            return Ok();
        }
    }
}
