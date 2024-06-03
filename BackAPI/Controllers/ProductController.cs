using BackAPI.Models;
using BackAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        [HttpPost("addProduct")]
        public async Task<IActionResult> AddProduct([FromBody] ProductModel product)
        {
            _logger.LogInformation("Добавление продукта");

            return Ok(await _productService.AddProduct(product));
        }
        [HttpGet("GetProduct")]
        public async Task<IActionResult> AllProducts()
        {
            _logger.LogInformation("Список продуктов");

            return Ok(await _productService.GetAllProducts());
        }
    }
}
