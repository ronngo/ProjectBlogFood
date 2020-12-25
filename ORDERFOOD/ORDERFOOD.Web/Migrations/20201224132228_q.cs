using Microsoft.EntityFrameworkCore.Migrations;

namespace ORDERFOOD.Web.Migrations
{
    public partial class q : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "Foods",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Foods",
                newName: "FoodId");
        }
    }
}
