using ProductDomain.Dtos.Request;
using ProductDomain.Models;

namespace ProductApplication.Extensions.Mappers
{
    public static class ProductMapper
    {
        public static Product ToProduct(CreateProductDto createProduct)
        {
            return new Product
            {
                Name = createProduct.Name,
                Description = createProduct.Description,
                Price = createProduct.Price,
                Category = createProduct.Category,
                ImageUrl = createProduct.ImageUrl,
                Tags = createProduct.Tags,
                Discount = new Discount(),
                InventoryItem = new InventoryItem(),
                ReviewStars = new List<Review>()
            };
        }
    }
}
