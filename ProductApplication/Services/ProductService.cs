using ProductApplication.Extensions.Mappers;
using ProductDomain.Dtos.Request;
using ProductDomain.Dtos.Response;
using ProductDomain.Interfaces.Repositories;
using ProductDomain.Interfaces.Services;
using ProductDomain.Models;
using ProductInfrastructure.Repositories;

namespace ProductApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<bool> CreateProduct(CreateProductDto productDto)
        {
            //get category name if the ID exist
            var getCategoryName = await _repositoryManager.CategoryTypeRepository.FindCategoryNameById(productDto.CategoryId);
            if (string.IsNullOrEmpty(getCategoryName))
            {
                return false;
            }

            //get tag names if the IDs exist
            var getTagNames = await _repositoryManager.TagRepository.GetTagNamesByIds(productDto.Tags);


            var product = ProductMapper<Product, CreateProductDto>.ToProduct(productDto);
            product.Category = getCategoryName;
            product.Tags = getTagNames;
            await _repositoryManager.ProductRepository.CreateProductAsync(product);
            await _repositoryManager.SaveAsync();

            return true;
        }

        public async Task<ProductDto> GetProductById(string id)
        {
            var product = await _repositoryManager.ProductRepository.GetProductByIdAsync(id);
            return (ProductDto)product;
        }
        public async Task<List<ProductDto>> GetProducts()
        {
            var result = new List<ProductDto>();
            var products = await _repositoryManager.ProductRepository.GetProductsAsync();
            foreach (var product in products)
            {
                result.Add((ProductDto)product);
            }
            return result;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var checkIfProduc = await _repositoryManager.ProductRepository.GetProductByIdAsync(product.ProductId.ToString());
            if(checkIfProduc == null)
            {
                return false;
            }

            _repositoryManager.ProductRepository.UpdateProductAsync(product);
            return true;
        }

        public async Task<bool> DeleteProductById(string id)
        {
            var checkIfProduc = await _repositoryManager.ProductRepository.GetProductByIdAsync(id);
            if (checkIfProduc == null)
            {
                return false;
            }

            _repositoryManager.ProductRepository.DeleteProductAsync(checkIfProduc);
            return true;
        }

    }
}
