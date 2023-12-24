using ProductDomain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Dtos.Response
{
    public class ProductDto
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        //[NotMapped] // Mark this property as not mapped to the database
        public ICollection<string> TagNames { get; set; }


        public static explicit operator ProductDto(Product product)
        {
            return new ProductDto
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Category = product.Category,
                ImageUrl = product.ImageUrl,
                TagNames = product.TagNames
                // Discount = new Discount(),
                // InventoryItem = new InventoryItem(),
                // ReviewStars = new List<Review>()
            };
        }
    }
}
