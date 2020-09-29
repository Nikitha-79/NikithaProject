using Microsoft.EntityFrameworkCore.Migrations;

namespace NikithaProject.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageFileName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageName", "ImageFileName", "Price" },
                values: new object[] { 1, "Freshly Baked Choco chip Cookies", "ChocolateChipCookies.jpg", "Cookies", 25.5f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageName", "ImageFileName", "Price" },
                values: new object[] { 2, "Delicious Baked CupCake", "Cupcake.jpg", "CupCake", 55.5f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageName", "ImageFileName", "Price" },
                values: new object[] { 3, "Chololate Donut", "Donut.jpg", "Donut", 25.5f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
