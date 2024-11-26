using Microsoft.AspNetCore.Mvc;

namespace Theolez.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("Index")]
    public async Task<IActionResult> Index()
    {
        return Ok("OK");
    }
}
