using Microsoft.AspNetCore.Mvc;
using ProductAPI.ActionFilters;
using ProductDomain.Dtos.Request;
using ProductDomain.Interfaces.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _productService.GetProducts();
            return Ok(response);
        }

        [HttpPost]
        [ServiceFilter(typeof(CreateProductValidation))]
        public async Task<IActionResult> CreateProduct(CreateProductDto request)
        {
            var response = await _productService.CreateProduct(request);
            return Ok(response);
        }
    }
}
