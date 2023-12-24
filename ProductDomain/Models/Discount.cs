using System.ComponentModel.DataAnnotations;

namespace ProductDomain.Models
{
    public class Discount
    {
        //  EACH DISCOUNT FOR ONE PRODUCT
        [Key]
        public long ProductId { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public DateTime DiscountValidity { get; set; }
    }
}
