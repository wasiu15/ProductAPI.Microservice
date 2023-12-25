using ProductDomain.Dtos.Response;
using ProductDomain.Models;

namespace ProductDomain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task<ProductDto> GetProductByIdAsync(string id);
        Task<List<ProductDto>> GetProductsAsync();
        void DeleteProductByIdAsync(Product product);
        void UpdateProduct(Product product);
    }
}
