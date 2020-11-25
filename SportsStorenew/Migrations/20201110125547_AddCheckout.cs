using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStoreNew.Migrations
{
    public partial class AddCheckout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckoutViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 160, nullable: false),
                    Surname = table.Column<string>(maxLength: 160, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 70, nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutViewModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckoutViewModels");
        }
    }
}
