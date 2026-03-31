using Microsoft.AspNetCore.Mvc;
namespace ProductApi.Controllers
{
[ApiController]
[Route("/api/[controller]")] 
public class CategoryController: Controller
{
    [HttpGet("Category")]
    public IActionResult Category()
    {
        return Ok("This is Category Response");
    }
}

}