using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStoreNew.Migrations
{
    public partial class AddDiscountPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddToCarts_Products_ProductId",
                table: "AddToCarts");

           

            migrationBuilder.AddColumn<int>(
                name: "DiscountPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "AddToCarts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddToCarts_Products_ProductId",
                table: "AddToCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddToCarts_Products_ProductId",
                table: "AddToCarts");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "AddToCarts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));


            migrationBuilder.AddForeignKey(
                name: "FK_AddToCarts_Products_ProductId",
                table: "AddToCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
