using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace satinalma.Migrations
{
    public partial class sonuc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Categoriescategory_id",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Categoriescategory_id",
                table: "Products",
                column: "Categoriescategory_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_Categoriescategory_id",
                table: "Products",
                column: "Categoriescategory_id",
                principalTable: "Categories",
                principalColumn: "category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_Categoriescategory_id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_Categoriescategory_id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Categoriescategory_id",
                table: "Products");
        }
    }
}
