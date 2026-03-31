using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Models;

namespace AddProductList.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class AddProductListController : Controller
    {
        [HttpPost("add")]
        public IActionResult AddProduct([FromBody] Product addProduct)
        {
            addProduct.Id = ProductData.Products.Count + 1;
            ProductData.Products.Add(addProduct);
            return Ok( new { results = addProduct});
        }
    }


}