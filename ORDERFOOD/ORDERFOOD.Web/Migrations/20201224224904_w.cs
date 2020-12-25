using Microsoft.EntityFrameworkCore.Migrations;

namespace ORDERFOOD.Web.Migrations
{
    public partial class w : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderFoodId",
                table: "ProductTag",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Person = table.Column<int>(type: "int", nullable: false),
                    Isdeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderFood_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_OrderFoodId",
                table: "ProductTag",
                column: "OrderFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderFood_CategoryId",
                table: "OrderFood",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTag_OrderFood_OrderFoodId",
                table: "ProductTag",
                column: "OrderFoodId",
                principalTable: "OrderFood",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTag_OrderFood_OrderFoodId",
                table: "ProductTag");

            migrationBuilder.DropTable(
                name: "OrderFood");

            migrationBuilder.DropIndex(
                name: "IX_ProductTag_OrderFoodId",
                table: "ProductTag");

            migrationBuilder.DropColumn(
                name: "OrderFoodId",
                table: "ProductTag");
        }
    }
}
