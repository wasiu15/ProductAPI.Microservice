using System.ComponentModel.DataAnnotations;

namespace ProductDomain.Models
{
    public class InventoryItem
    {
        //  WE CAN HAVE MULTIPLE INVENTORY FOR DIFFERENT LOCATIONS
        //  BUT ONLY THE TOTAL WILL BE RETURNED TO THE PRODUCT WITH EITHER THE STORE NAME OR AVAILABLE IN MULTIPLE STORES
        [Key]
        public long InventoryItemId { get; set; }
        public long ProductId { get; set; }
        public string Location { get; set; }
        public int QuantityAvailable { get; set; }
        public string Status { get; set; }
        public Product Product { get; set; }
        //  PRODUCT CAN HAVE MORE THAN ONE INVENTORY IS THE PURPOSE OF THE RELATIONSHIP
    }
}
