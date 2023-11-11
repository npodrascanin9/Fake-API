using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FakeAPI.Controllers
{
    [Route("api/tests")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(value: new List<object>()
            {
                new { Id = 1, Name = "I'm a fake "},
                new { Id = 2, Name = "Yeah, and I'm a fake 2!" },
                new { Id = 3, Name = "Fakes are ment for testing... Better known as: KISS principle"}
            });
        }
    }
}
