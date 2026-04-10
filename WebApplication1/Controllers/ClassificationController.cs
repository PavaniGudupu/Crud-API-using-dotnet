using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassificationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetClassificationList()
        {
            return Ok(ClassificationData.Classifications);
        }

        [HttpGet("{id}")]
        public IActionResult GetClassificationById(int id)
        {
            var classification = ClassificationData.Classifications
                .FirstOrDefault(c => c.ClassificationId == id);

            if (classification == null)
                return NotFound($"Classification not found with id: {id}");

            return Ok(classification);
        }

        [HttpGet("search")]
        public IActionResult GetClassificationByName([FromQuery] string name)
        {
            var classification = ClassificationData.Classifications
                .FirstOrDefault(c => c.ClassificationName.ToLower() == name.ToLower());

            if (classification != null)
                return Ok(classification);

            return NotFound($"Classification not found with name: {name}");
        }

        [HttpPost("add")]
        public IActionResult AddClassification([FromBody] ClassificationModel newClassification)
        {
            newClassification.ClassificationId = ClassificationData.Classifications.Max(c => c.ClassificationId) + 1;
            ClassificationData.Classifications.Add(newClassification);

            return Ok(newClassification);
        }

        [HttpPut("edit")]
        public IActionResult UpdateClassification(int id, [FromBody] ClassificationModel updatedClassification)
        {
            var classification = ClassificationData.Classifications
                .FirstOrDefault(c => c.ClassificationId == id);

            if (classification == null)
                return NotFound($"Classification not found with id: {id}");

            classification.ClassificationName = updatedClassification.ClassificationName;

            return Ok(classification);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClassification(int id)
        {
            var classification = ClassificationData.Classifications
                .FirstOrDefault(c => c.ClassificationId == id);

            if (classification == null)
                return NotFound($"Classification not found with id: {id}");

            ClassificationData.Classifications.Remove(classification);

            return Ok("Classification deleted successfully");
        }
    }
}