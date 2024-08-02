using Microsoft.AspNetCore.Mvc;

namespace YourAssetManager.Server
{
    [Route("YourAssetManager.Server/{controller}")]
    class AuthenticationController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Helloo ");
        }
    }
}