using ProductDomain.Dtos.Response;
using ProductDomain.Models;

namespace ProductDomain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task<Product> GetProductByIdAsync(string id);
        Task<List<Product>> GetProductsAsync();
        void DeleteProductAsync(Product product);
        void UpdateProductAsync(Product product);
    }
}
