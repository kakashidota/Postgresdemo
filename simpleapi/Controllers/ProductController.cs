using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleapi.Data;
using simpleapi.Models;

namespace simpleapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ApiDbContext _context;

        public ProductController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetAllProducts")]
        public async Task<IActionResult> Get()
        {
            
            var product = new Product()
            {
                Name = "King Edward potatoes",
                ProductId = 44
            };

            _context.Add(product);
            await _context.SaveChangesAsync();

            var allproducts = await _context.Products.ToListAsync();

            return Ok(allproducts);

        }
    }
}
