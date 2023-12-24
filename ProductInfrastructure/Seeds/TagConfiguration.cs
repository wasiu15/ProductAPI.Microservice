using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductDomain.Models;

namespace ProductInfrastructure.Seeds
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasData(
                new Tag { TagId = 1, Name = "Italian" },
                    new Tag { TagId = 2, Name = "Chinese" },
                    new Tag { TagId = 3, Name = "Indian" },
                    new Tag { TagId = 4, Name = "Mexican" },
                    new Tag { TagId = 5, Name = "French" },
                    new Tag { TagId = 6, Name = "Japanese" },
                    new Tag { TagId = 7, Name = "Thai" },
                    new Tag { TagId = 8, Name = "Mediterranean" },
                    new Tag { TagId = 9, Name = "Vegetarian" },
                    new Tag { TagId = 10, Name = "Vegan" },
                    new Tag { TagId = 11, Name = "Gluten - Free" },
                    new Tag { TagId = 12, Name = "Dairy - Free" },
                    new Tag { TagId = 13, Name = "Keto" },
                    new Tag { TagId = 14, Name = "Paleo" },
                    new Tag { TagId = 15, Name = "Organic" },
                    new Tag { TagId = 16, Name = "Fruits" },
                    new Tag { TagId = 17, Name = "Vegetables" },
                    new Tag { TagId = 18, Name = "Dairy & Eggs" },
                    new Tag { TagId = 19, Name = "Meat & Poultry" },
                    new Tag { TagId = 20, Name = "Seafood" },
                    new Tag { TagId = 21, Name = "Baked Goods" },
                    new Tag { TagId = 22, Name = "Beverages" },
                    new Tag { TagId = 23, Name = "Snacks" },
                    new Tag { TagId = 24, Name = "Pizza" },
                    new Tag { TagId = 25, Name = "Pasta" },
                    new Tag { TagId = 26, Name = "Sushi" },
                    new Tag { TagId = 27, Name = "Tacos" },
                    new Tag { TagId = 28, Name = "Burgers" },
                    new Tag { TagId = 29, Name = "Salads" },
                    new Tag { TagId = 30, Name = "Soups" },
                    new Tag { TagId = 31, Name = "Desserts" }
            );
        }
    }
}
