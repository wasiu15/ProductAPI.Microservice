using ProductDomain.Models;

namespace ProductDomain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task<Product> GetProductByIdAsync(string id);
        Task<List<Product>> GetProductsAsync();
        Task<bool> DeleteProductByIdAsync(string id);
    }
}
