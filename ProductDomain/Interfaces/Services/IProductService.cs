using ProductDomain.Dtos.Request;
using ProductDomain.Models;

namespace ProductDomain.Interfaces.Services
{
    public interface IProductService
    {
        Task<bool> CreateProduct(CreateProductDto product);
        Task<Product> GetProductById(string id);
        Task<List<Product>> GetProducts();
    }
}
