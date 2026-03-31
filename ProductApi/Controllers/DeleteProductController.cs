using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Data;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class DeleteProductController: Controller
    {
        [HttpDelete]
        public IActionResult deleteProduct(int id)
        {
            var fetchProduct = ProductData.Products.FirstOrDefault(p => p.Id == id);
            if(fetchProduct == null)
            {
                return NotFound(new { message = "Product Not Found" });
            }
            ProductData.Products.Remove(fetchProduct);
            return Ok(new { message = "Product deleted successfully" });
         }
    }
}