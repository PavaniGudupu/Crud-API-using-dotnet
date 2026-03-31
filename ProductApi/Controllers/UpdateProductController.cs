using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Data;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class UpdateProductController: Controller
    {
        [HttpPut]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var fetchedProdcut = ProductData.Products.FirstOrDefault(p => p.Id == id);
            if(fetchedProdcut == null)
            {
                return NotFound(new { message = "Product not Found " });
            }
            fetchedProdcut.ProductName = updatedProduct.ProductName;
            fetchedProdcut.CategoryId = updatedProduct.CategoryId;
            fetchedProdcut.Mrp = updatedProduct.Mrp;
            fetchedProdcut.Sp = updatedProduct.Sp;
            fetchedProdcut.Cp = updatedProduct.Cp;
            fetchedProdcut.Classification = updatedProduct.Classification;
            fetchedProdcut.Size = updatedProduct.Size;
            fetchedProdcut.Category = updatedProduct.Category;

            return Ok(new { result = fetchedProdcut });
        }
    }
}