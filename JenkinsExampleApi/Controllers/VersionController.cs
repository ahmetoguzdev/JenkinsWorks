using Microsoft.AspNetCore.Mvc;

namespace JenkinsExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        IConfiguration _configuration;

        public VersionController(IConfiguration configuration)
        {
            _configuration = configuration;    
        }

        [HttpGet]
        public IActionResult GetVersion()
        {
            return Ok($"Api Version: {_configuration.GetSection("ApiVersion").Value}");
        }
    }
}
