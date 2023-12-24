using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updated_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTag",
                columns: table => new
                {
                    ProductsProductId = table.Column<long>(type: "bigint", nullable: false),
                    TagsTagId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTag", x => new { x.ProductsProductId, x.TagsTagId });
                    table.ForeignKey(
                        name: "FK_ProductTag_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTag_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 1L, "Italian" },
                    { 2L, "Chinese" },
                    { 3L, "Indian" },
                    { 4L, "Mexican" },
                    { 5L, "French" },
                    { 6L, "Japanese" },
                    { 7L, "Thai" },
                    { 8L, "Mediterranean" },
                    { 9L, "Vegetarian" },
                    { 10L, "Vegan" },
                    { 11L, "Gluten - Free" },
                    { 12L, "Dairy - Free" },
                    { 13L, "Keto" },
                    { 14L, "Paleo" },
                    { 15L, "Organic" },
                    { 16L, "Fruits" },
                    { 17L, "Vegetables" },
                    { 18L, "Dairy & Eggs" },
                    { 19L, "Meat & Poultry" },
                    { 20L, "Seafood" },
                    { 21L, "Baked Goods" },
                    { 22L, "Beverages" },
                    { 23L, "Snacks" },
                    { 24L, "Pizza" },
                    { 25L, "Pasta" },
                    { 26L, "Sushi" },
                    { 27L, "Tacos" },
                    { 28L, "Burgers" },
                    { 29L, "Salads" },
                    { 30L, "Soups" },
                    { 31L, "Desserts" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_TagsTagId",
                table: "ProductTag",
                column: "TagsTagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTag");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
