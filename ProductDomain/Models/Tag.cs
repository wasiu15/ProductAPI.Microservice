using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Models
{
    public class Tag
    {
        [Key]
        public long TagId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
