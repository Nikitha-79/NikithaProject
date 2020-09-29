using Microsoft.EntityFrameworkCore.Migrations;

namespace NikithaProject.Data.Migrations
{
    public partial class AddedNewRowIntoProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageName", "ImageFileName", "Price" },
                values: new object[] { 4, "Spicy vegetarian Puff", "VegPuffs.jpg", "Veg Puff", 20f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
