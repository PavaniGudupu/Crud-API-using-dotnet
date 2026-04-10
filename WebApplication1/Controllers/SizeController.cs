using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SizeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSizeList()
        {
            return Ok(SizeData.Sizes);
        }

        [HttpGet("{id}")]
        public IActionResult GetSizeById(int id)
        {
            var size = SizeData.Sizes
                .FirstOrDefault(s => s.SizeId == id);

            if (size == null)
                return NotFound($"Size not found with id: {id}");

            return Ok(size);
        }

        [HttpGet("search")]
        public IActionResult GetSizeByName([FromQuery] string name)
        {
            var size = SizeData.Sizes
                .FirstOrDefault(s => s.SizeName.ToLower() == name.ToLower());

            if (size != null)
                return Ok(size);

            return NotFound($"Size not found with name: {name}");
        }

        [HttpPost("add")]
        public IActionResult AddSize([FromBody] SizeModel newSize)
        {
            newSize.SizeId = SizeData.Sizes.Max(s => s.SizeId) + 1;
            SizeData.Sizes.Add(newSize);

            return Ok(newSize);
        }

        [HttpPut("edit")]
        public IActionResult UpdateSize(int id, [FromBody] SizeModel updatedSize)
        {
            var size = SizeData.Sizes
                .FirstOrDefault(s => s.SizeId == id);

            if (size == null)
                return NotFound($"Size not found with id: {id}");

            size.SizeName = updatedSize.SizeName;

            return Ok(size);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSize(int id)
        {
            var size = SizeData.Sizes
                .FirstOrDefault(s => s.SizeId == id);

            if (size == null)
                return NotFound($"Size not found with id: {id}");

            SizeData.Sizes.Remove(size);

            return Ok("Size deleted successfully");
        }
    }
}