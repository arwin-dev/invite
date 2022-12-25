using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace invite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            var result = await _productService.GetProductAsync();
            return Ok(result);
        }

    }
}