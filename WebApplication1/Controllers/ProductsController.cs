using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "İskender", "Lahmacun", "Kebap","...",
    };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Products> Get()
        {
            return Enumerable.Range(1, 3).Select(index => new Products
            {
                ProductId = index,
                ProductName = $"{index}",
            })
            .ToArray();
        }



        [HttpPost(Name = "PostProducts")]
        public IEnumerable<Products> Post()
        {
            return Enumerable.Range(1, 3).Select(index => new Products
            {
                ProductId = index,
                ProductName = $"{index}",
            })
            .ToArray();
        }


        [HttpPut("{id}", Name = "PutProduct")]
        public IActionResult Put(int id, [FromBody] Products updatedProduct)
        {
            if (updatedProduct == null)
            {
                return BadRequest();
            }

            // if success
            return NoContent();
        }

        [HttpDelete("{id}", Name = "PutProduct")]
        public IActionResult Delete(int id, [FromBody] Products updatedProduct)
        {
            if (updatedProduct == null)
            {
                return BadRequest();
            }

            // if success
            return NoContent();
        }


    }
}