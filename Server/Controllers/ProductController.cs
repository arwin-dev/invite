using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace invite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var Products =  await _context.Products.ToListAsync();
            return Ok(Products);
        }

    }
}