using ProductDomain.Dtos.Request;
using ProductDomain.Dtos.Response;
using ProductDomain.Models;

namespace ProductDomain.Interfaces.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(string id);
        Task<bool> CreateProduct(CreateProductDto product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProductById(string id);
    }
}
