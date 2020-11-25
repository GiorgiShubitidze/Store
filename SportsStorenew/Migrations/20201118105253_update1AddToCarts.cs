using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStoreNew.Migrations
{
    public partial class update1AddToCarts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "AddToCarts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AddToCarts_ProductId",
                table: "AddToCarts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddToCarts_Products_ProductId",
                table: "AddToCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddToCarts_Products_ProductId",
                table: "AddToCarts");

            migrationBuilder.DropIndex(
                name: "IX_AddToCarts_ProductId",
                table: "AddToCarts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "AddToCarts");
        }
    }
}
