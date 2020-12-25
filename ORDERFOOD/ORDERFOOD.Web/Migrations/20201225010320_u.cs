using Microsoft.EntityFrameworkCore.Migrations;

namespace ORDERFOOD.Web.Migrations
{
    public partial class u : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderFood_Categories_CategoryId",
                table: "OrderFood");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTag_OrderFood_OrderFoodId",
                table: "ProductTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderFood",
                table: "OrderFood");

            migrationBuilder.RenameTable(
                name: "OrderFood",
                newName: "OrderFoods");

            migrationBuilder.RenameIndex(
                name: "IX_OrderFood_CategoryId",
                table: "OrderFoods",
                newName: "IX_OrderFoods_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderFoods",
                table: "OrderFoods",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderFoods_Categories_CategoryId",
                table: "OrderFoods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTag_OrderFoods_OrderFoodId",
                table: "ProductTag",
                column: "OrderFoodId",
                principalTable: "OrderFoods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderFoods_Categories_CategoryId",
                table: "OrderFoods");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTag_OrderFoods_OrderFoodId",
                table: "ProductTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderFoods",
                table: "OrderFoods");

            migrationBuilder.RenameTable(
                name: "OrderFoods",
                newName: "OrderFood");

            migrationBuilder.RenameIndex(
                name: "IX_OrderFoods_CategoryId",
                table: "OrderFood",
                newName: "IX_OrderFood_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderFood",
                table: "OrderFood",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderFood_Categories_CategoryId",
                table: "OrderFood",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTag_OrderFood_OrderFoodId",
                table: "ProductTag",
                column: "OrderFoodId",
                principalTable: "OrderFood",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
