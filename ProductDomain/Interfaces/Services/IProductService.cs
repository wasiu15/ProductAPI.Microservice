using ProductDomain.Dtos.Request;
using ProductDomain.Dtos.Response;
using ProductDomain.Models;

namespace ProductDomain.Interfaces.Services
{
    public interface IProductService
    {
        Task<bool> CreateProduct(CreateProductDto product);
        Task<ProductDto> GetProductById(string id);
        Task<List<ProductDto>> GetProducts();
    }
}
