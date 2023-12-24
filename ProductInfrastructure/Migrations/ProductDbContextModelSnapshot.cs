﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductInfrastructure.Data;

#nullable disable

namespace ProductInfrastructure.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductDomain.Models.CategoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categoryTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dinner"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Salad"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Drink"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Fruit"
                        });
                });

            modelBuilder.Entity("ProductDomain.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductDomain.Models.Tag", b =>
                {
                    b.Property<long>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TagId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = 1L,
                            Name = "Italian"
                        },
                        new
                        {
                            TagId = 2L,
                            Name = "Chinese"
                        },
                        new
                        {
                            TagId = 3L,
                            Name = "Indian"
                        },
                        new
                        {
                            TagId = 4L,
                            Name = "Mexican"
                        },
                        new
                        {
                            TagId = 5L,
                            Name = "French"
                        },
                        new
                        {
                            TagId = 6L,
                            Name = "Japanese"
                        },
                        new
                        {
                            TagId = 7L,
                            Name = "Thai"
                        },
                        new
                        {
                            TagId = 8L,
                            Name = "Mediterranean"
                        },
                        new
                        {
                            TagId = 9L,
                            Name = "Vegetarian"
                        },
                        new
                        {
                            TagId = 10L,
                            Name = "Vegan"
                        },
                        new
                        {
                            TagId = 11L,
                            Name = "Gluten - Free"
                        },
                        new
                        {
                            TagId = 12L,
                            Name = "Dairy - Free"
                        },
                        new
                        {
                            TagId = 13L,
                            Name = "Keto"
                        },
                        new
                        {
                            TagId = 14L,
                            Name = "Paleo"
                        },
                        new
                        {
                            TagId = 15L,
                            Name = "Organic"
                        },
                        new
                        {
                            TagId = 16L,
                            Name = "Fruits"
                        },
                        new
                        {
                            TagId = 17L,
                            Name = "Vegetables"
                        },
                        new
                        {
                            TagId = 18L,
                            Name = "Dairy & Eggs"
                        },
                        new
                        {
                            TagId = 19L,
                            Name = "Meat & Poultry"
                        },
                        new
                        {
                            TagId = 20L,
                            Name = "Seafood"
                        },
                        new
                        {
                            TagId = 21L,
                            Name = "Baked Goods"
                        },
                        new
                        {
                            TagId = 22L,
                            Name = "Beverages"
                        },
                        new
                        {
                            TagId = 23L,
                            Name = "Snacks"
                        },
                        new
                        {
                            TagId = 24L,
                            Name = "Pizza"
                        },
                        new
                        {
                            TagId = 25L,
                            Name = "Pasta"
                        },
                        new
                        {
                            TagId = 26L,
                            Name = "Sushi"
                        },
                        new
                        {
                            TagId = 27L,
                            Name = "Tacos"
                        },
                        new
                        {
                            TagId = 28L,
                            Name = "Burgers"
                        },
                        new
                        {
                            TagId = 29L,
                            Name = "Salads"
                        },
                        new
                        {
                            TagId = 30L,
                            Name = "Soups"
                        },
                        new
                        {
                            TagId = 31L,
                            Name = "Desserts"
                        });
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.Property<long>("ProductsProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("TagsTagId")
                        .HasColumnType("bigint");

                    b.HasKey("ProductsProductId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("ProductTag", b =>
                {
                    b.HasOne("ProductDomain.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductDomain.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
