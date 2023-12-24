using System.ComponentModel.DataAnnotations;

namespace ProductDomain.Models
{
    public class Review
    {
        //  USERS CAN LOGIN AND CHANGE THEIR REVIEWS
        [Key]
        public long ReviewId { get; set; }
        public long ProductId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int Rating { get; set; }
        public Product Product { get; set; }
        //  REVIEW CAN HAVE MORE THAN ONE INVENTORY IS THE PURPOSE OF THE RELATIONSHIP
    }
}