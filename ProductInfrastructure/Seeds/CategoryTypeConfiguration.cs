using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProductDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfrastructure.Seeds
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<CategoryType>
    {
        public void Configure(EntityTypeBuilder<CategoryType> builder)
        {
            builder.HasData(
                new CategoryType { Id = 1, Name = "Breakfast" },
                new CategoryType { Id = 2, Name = "Lunch" },
                new CategoryType { Id = 3, Name = "Dinner" },
                new CategoryType { Id = 4, Name = "Salad" },
                new CategoryType { Id = 5, Name = "Drink" },
                new CategoryType { Id = 6, Name = "Fruit" }
            );
        }
    }
}
