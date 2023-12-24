using ProductApplication.Extensions.Mappers;
using ProductDomain.Dtos.Request;
using ProductDomain.Interfaces.Repositories;
using ProductDomain.Interfaces.Services;
using ProductDomain.Models;

namespace ProductApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> CreateProduct(CreateProductDto productDto)
        {
            //check if category exist
            var product = ProductMapper.ToProduct(productDto);
            await _productRepository.CreateProductAsync(product);
            return true;
        }

        public async Task<Product> GetProductById(string id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            return product;
        }
        public async Task<List<Product>> GetProducts()
        {
            var product = await _productRepository.GetProductsAsync();
            return product;
        }

    }
}
