using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLProvider.Migrations
{
    public partial class UpdateProductImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "ProductImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "ProductImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
