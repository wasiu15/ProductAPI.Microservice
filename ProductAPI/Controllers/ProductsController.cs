using Microsoft.AspNetCore.Mvc;
using ProductAPI.ActionFilters;
using ProductDomain.Dtos.Request;
using ProductDomain.Interfaces.Services;
using ProductDomain.Models;

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


        [HttpPost]
        [ServiceFilter(typeof(CreateProductValidation))]
        public async Task<IActionResult> CreateProduct(CreateProductDto request)
        {
            var response = await _productService.CreateProduct(request);
            return Ok(response);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _productService.GetProducts();
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductById(string id)
        {
            var response = await _productService.GetProductById(id);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var response = await _productService.UpdateProduct(product);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductById(string id)
        {
            var response = await _productService.DeleteProductById(id);
            return Ok(response);
        }
    }
}
