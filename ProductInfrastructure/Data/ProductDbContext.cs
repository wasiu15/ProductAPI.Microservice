using Azure;
using Microsoft.EntityFrameworkCore;
using ProductDomain.Models;
using ProductInfrastructure.Seeds;
using System.IO;

namespace ProductInfrastructure.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        //public DbSet<Discount> Discounts { get; set; }
        //public DbSet<InventoryItem> InventoryItems { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        public DbSet<CategoryType> categoryTypes { get; set; }
    }
}