using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Food", "Drink", "Dessert"
    };

        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCategories")]
        public IEnumerable<Categories> Get()
        {
            return Enumerable.Range(1, 3).Select(index => new Categories
            {
                CategoryId = index, 
                CategoryName= $"{index}",
            })
            .ToArray();
        }



        [HttpPost(Name = "PostCategories")]
        public IEnumerable<Categories> Post()
        {
            return Enumerable.Range(1, 3).Select(index => new Categories
            {
                CategoryId = index,
                CategoryName = $"{index}",
            })
            .ToArray();
        }


        [HttpPut("{id}", Name = "PutCategory")]
        public IActionResult Put(int id, [FromBody] Categories updatedCategory)
        {
            if (updatedCategory == null)
            {
                return BadRequest();
            }

            // if success
            return NoContent();
        }

        [HttpDelete("{id}", Name = "PutCategory")]
        public IActionResult Delete(int id, [FromBody] Categories updatedCategory)
        {
            if (updatedCategory == null)
            {
                return BadRequest();
            }

            // if success
            return NoContent();
        }


    }
}