using Microsoft.EntityFrameworkCore;
using ProductDomain.Models;

namespace ProductInfrastructure.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryType>().HasData(
                new CategoryType { Id = 1, Name = "Breakfast" },
                new CategoryType { Id = 2, Name = "Lunch" },
                new CategoryType { Id = 3, Name = "Dinner" },
                new CategoryType { Id = 4, Name = "Salad" },
                new CategoryType { Id = 5, Name = "Drink" },
                new CategoryType { Id = 6, Name = "Fruit" }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CategoryType> categoryTypes { get; set; }
    }
}
