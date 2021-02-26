using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLProvider.Migrations
{
    public partial class UpdateEntitiesNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Enrollments_ProductCategoryId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Enrollments_ParentCategoryId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_ProductId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "ProductImages");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_ParentCategoryId",
                table: "ProductCategories",
                newName: "IX_ProductCategories_ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_ProductCategoryId",
                table: "Products",
                newName: "IX_Products_ProductCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_ProductCategories_ParentCategoryId",
                table: "ProductCategories",
                column: "ParentCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_ProductCategories_ParentCategoryId",
                table: "ProductCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "Enrollments");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Courses",
                newName: "IX_Courses_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "Students",
                newName: "IX_Students_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategories_ParentCategoryId",
                table: "Enrollments",
                newName: "IX_Enrollments_ParentCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Enrollments_ProductCategoryId",
                table: "Courses",
                column: "ProductCategoryId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Enrollments_ParentCategoryId",
                table: "Enrollments",
                column: "ParentCategoryId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_ProductId",
                table: "Students",
                column: "ProductId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
