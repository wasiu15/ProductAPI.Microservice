using ProductDomain.Dtos.Request;
using ProductDomain.Dtos.Response;
using ProductDomain.Models;

namespace ProductApplication.Extensions.Mappers
{
    public static class ProductMapper<TEntity, TDto>
    {
        public static TEntity ToProduct(TDto dto)
        {
            // Implement mapping logic for TEntity based on TDto properties
            // Example implementation for Product based on CreateProductDto
            if (typeof(TEntity) == typeof(Product) && typeof(TDto) == typeof(CreateProductDto))
            {
                var createProduct = (CreateProductDto)(object)dto;
                return (TEntity)(object)new Product
                {
                    Name = createProduct.Name,
                    Description = createProduct.Description,
                    Price = createProduct.Price,
                    Category = "",
                    ImageUrl = createProduct.ImageUrl,
                    Tags = new List<Tag>()
                    // Discount = new Discount(),
                    // InventoryItem = new InventoryItem(),
                    // ReviewStars = new List<Review>()
                };
            } 
            else if (typeof(TEntity) == typeof(ProductDto) && typeof(TDto) == typeof(Product))
            {
                var createProduct = (Product)(object)dto;
                return (TEntity)(object)new ProductDto
                {
                    ProductId = createProduct.ProductId,
                    Name = createProduct.Name,
                    Description = createProduct.Description,
                    Price = createProduct.Price,
                    Category = "",
                    ImageUrl = createProduct.ImageUrl,
                    TagNames = createProduct.TagNames
                    // Discount = new Discount(),
                    // InventoryItem = new InventoryItem(),
                    // ReviewStars = new List<Review>()
                };
            }

            // Add additional mappings for other entity types and DTOs as needed

            throw new ArgumentException("Mapping not implemented for the provided types.");
        }
    }

}
