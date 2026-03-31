using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class ProductListController: Controller
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new { results = ProductData.Products });
        }

        //[HttpPost("add")]
        //public IActionResult AddProduct([FromBody] Product product)
        //{
        //    product.Id = ProductData.Products.Count + 1;

        //    ProductData.Products.Add(product);

        //    return Ok(new { results = product });
        //}
    }
}