using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStoreNew.Migrations
{
    public partial class updateAddToCarts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AddToCarts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AddToCarts");
        }
    }
}
