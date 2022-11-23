using Microsoft.AspNetCore.Mvc;

namespace ExampleMicroServiceUser.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet(nameof(Get))]
        public IActionResult Get()
        {
            return Ok("UserController çalıştı");
        }
    }
}
