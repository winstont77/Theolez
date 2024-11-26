using Microsoft.AspNetCore.Mvc;

namespace Theolez.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return Ok();
    }
}
