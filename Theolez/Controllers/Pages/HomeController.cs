using Microsoft.AspNetCore.Mvc;

namespace Theolez.Controllers.Pages;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }
}



