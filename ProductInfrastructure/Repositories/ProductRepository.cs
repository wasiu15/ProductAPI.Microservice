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

        public void UpdateProductAsync(Product product)
        {
            _dbContext.Products.Update(product);
        }

        public void DeleteProductAsync(Product product)
        {
            _dbContext.Products.Remove(product);
        }

        public async Task<Product> GetProductByIdAsync(string id)
        {
            var product = await _dbContext.Products.Where(product => product.ProductId.ToString() == id).FirstOrDefaultAsync();
            return product;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products = new List<Product>();
            var productsWithTags = await _dbContext.Products
                .Include(p => p.Tags)
                .ToListAsync();

            foreach (var product in productsWithTags)
            {
                var currentProduct = product;
                currentProduct.TagNames = product.Tags.Select(tag => tag.Name).ToList();
                products.Add(currentProduct);
            }
            return products;
        }
    }
}
