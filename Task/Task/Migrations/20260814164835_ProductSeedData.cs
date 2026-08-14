using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "Name", "Price", "rate" },
                values: new object[,]
                {
                    { 1, "Ergonomic wireless mouse with USB receiver", "Wireless Mouse", 15.99m, 4 },
                    { 2, "RGB backlit mechanical keyboard", "Mechanical Keyboard", 49.99m, 5 },
                    { 3, "7-in-1 USB-C hub with HDMI and card reader", "USB-C Hub", 29.50m, 3 },
                    { 4, "Adjustable aluminum laptop stand", "Laptop Stand", 22.00m, 4 },
                    { 5, "Full HD webcam with built-in microphone", "Webcam 1080p", 34.99m, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
