using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCategoryList()
        {
            return Ok(CategoryData.Categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = CategoryData.Categories
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
                return NotFound($"Category not found with id: {id}");

            return Ok(category);
        }

        [HttpGet("search")]
        public IActionResult GetCategoryByName([FromQuery] string name)
        {
            var category = CategoryData.Categories
                .FirstOrDefault(c => c.CategoryName.ToLower() == name.ToLower());

            if (category != null)
                return Ok(category);

            return NotFound($"Category not found with name: {name}");
        }

        [HttpPost("add")]
        public IActionResult AddCategory([FromBody] CategoryModel newCategory)
        {
            newCategory.CategoryId = CategoryData.Categories.Max(c => c.CategoryId) + 1;
            CategoryData.Categories.Add(newCategory);

            return Ok(newCategory);
        }

        [HttpPut("edit")]
        public IActionResult UpdateCategory(int id, [FromBody] CategoryModel updatedCategory)
        {
            var category = CategoryData.Categories
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
                return NotFound($"Category not found with id: {id}");

            category.CategoryName = updatedCategory.CategoryName;

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = CategoryData.Categories
                .FirstOrDefault(c => c.CategoryId == id);

            if (category == null)
                return NotFound($"Category not found with id: {id}");

            CategoryData.Categories.Remove(category);

            return Ok("Category deleted successfully");
        }
    }
}