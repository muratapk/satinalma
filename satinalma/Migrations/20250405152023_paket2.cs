using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace satinalma.Migrations
{
    public partial class paket2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture_Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture_Image",
                table: "Products");
        }
    }
}
