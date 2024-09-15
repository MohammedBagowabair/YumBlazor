using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YumBlazor.Migrations
{
    /// <inheritdoc />
    public partial class NewDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, 1, "Crispy vegetable spring rolls with a tangy dipping sauce.", "/images/product/spring_rolls.jpg", "Spring Rolls", 5.99m, "Starter" },
                    { 2, 1, "Classic Caesar salad with croutons, parmesan, and Caesar dressing.", "/images/product/caesar_salad.jpg", "Caesar Salad", 8.99m, "Healthy" },
                    { 3, 2, "Juicy grilled chicken breast served with a side of vegetables.", "/images/product/grilled_chicken.jpg", "Grilled Chicken", 15.99m, "Popular" },
                    { 4, 2, "Beef burger with cheese, lettuce, tomato, and a side of fries.", "/images/product/Double-beef-burger.png", "Beef Burger", 12.99m, "Best Seller" },
                    { 5, 3, "Rich chocolate cake with a creamy ganache filling.", "/images/product/chocolate_cake.jpg", "Chocolate Cake", 6.99m, "Dessert" },
                    { 6, 3, "Classic New York cheesecake with a graham cracker crust.", "/images/product/cheesecake.jpg", "Cheesecake", 7.99m, "Sweet Treat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
