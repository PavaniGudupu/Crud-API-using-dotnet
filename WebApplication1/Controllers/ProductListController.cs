using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductListController : Controller
    {
        [HttpGet]
        public IActionResult GetProductList()
        {
            return Ok(new { result = ProductData.Products });
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var fetchProduct = ProductData.Products.FirstOrDefault((p) => p.ProductId == id);
            if(fetchProduct == null)
            {
                return NotFound($"Product Not Found with this {id}");
            }
            return Ok(fetchProduct);
        }
        [HttpGet("search")]
        public IActionResult GetProductByName([FromQuery] string name)
        {
            var fetchProduct = ProductData.Products
                .FirstOrDefault(p => p.ProductName?.ToLower() == name.ToLower());

            if (fetchProduct != null)
            {
                return Ok(fetchProduct);
            }

            return NotFound($"Product not found with name: {name}");
        }


        [HttpPost("add")]
        public IActionResult PostProduct([FromBody] ProductModel addProduct)
        {
            addProduct.ProductId = ProductData.Products.Max(p => p.ProductId) + 1;
            ProductData.Products.Add(addProduct);
            return Ok(addProduct);
        }

        [HttpPut("edit")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductModel editProduct)
        {
            var fetchProduct = ProductData.Products.FirstOrDefault((p) => p.ProductId == id);
            if(fetchProduct == null)
            {
                return NotFound($"Product not found with {id}");
            }
            fetchProduct.ProductName = editProduct.ProductName;
            fetchProduct.CategoryId = editProduct.CategoryId;
            fetchProduct.CategoryName = editProduct.CategoryName;
            fetchProduct.Mrp = editProduct.Mrp;
            fetchProduct.Sp = editProduct.Sp;
            fetchProduct.Cp = editProduct.Cp;
            fetchProduct.Classification = editProduct.Classification;
            fetchProduct.Size = editProduct.Size;

            return Ok(fetchProduct);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var fetchProduct = ProductData.Products.FirstOrDefault((p) => p.ProductId == id);
            if(fetchProduct == null)
            {
                return NotFound($"Product not found with this {id}");
            }
            ProductData.Products.Remove(fetchProduct);
            return Ok("Product Deleted Successfully");
        }


    }
}
