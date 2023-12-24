using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using ProductDomain.Dtos.Response;
using ProductDomain.Interfaces.Repositories;
using ProductDomain.Models;
using ProductInfrastructure.Data;

namespace ProductInfrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;
        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateProductAsync(Product product)
        {
            await _dbContext.Products.AddAsync(product);
        }

        public Task<bool> DeleteProductByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var products = new List<ProductDto>();
            var productsWithTags = await _dbContext.Products
                .Include(p => p.Tags)
                .ToListAsync();

            foreach (var product in productsWithTags)
            {
                var currentProduct = (ProductDto)product;
                currentProduct.TagNames = product.Tags.Select(tag => tag.Name).ToList();
                products.Add(currentProduct);
            }
            return products;
        }
    }
}
