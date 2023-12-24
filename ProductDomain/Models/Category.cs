using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductDomain.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify that the Id is database-generated
        public long Id { get; private set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
