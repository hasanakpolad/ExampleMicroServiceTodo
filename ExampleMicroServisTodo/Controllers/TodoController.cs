using Microsoft.AspNetCore.Mvc;

namespace ExampleMicroServiceTodo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet(nameof(Get))]
        public IActionResult Get()
        {
            return Ok("TodoController çalıştı");
        }
    }
}
