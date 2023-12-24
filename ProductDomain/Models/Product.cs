using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductDomain.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify that the Id is database-generated
        public long ProductId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }    // No seperate model for Image because our design only have one image
        //public Discount Discount { get; set; }
        //public InventoryItem InventoryItem { get; set; }
        //public List<Review> ReviewStars { get; set; }   // one to many

        [NotMapped] // Mark this property as not mapped to the database
        public ICollection<string> TagNames { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
