using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsStorenew.Migrations
{
    public partial class HasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 4, "Product 1", 21m },
                    { 73, 2, "Product 73", 93m },
                    { 72, 4, "Product 72", 92m },
                    { 71, 4, "Product 71", 91m },
                    { 70, 2, "Product 70", 90m },
                    { 69, 2, "Product 69", 89m },
                    { 68, 4, "Product 68", 88m },
                    { 67, 2, "Product 67", 87m },
                    { 66, 4, "Product 66", 86m },
                    { 65, 5, "Product 65", 85m },
                    { 64, 1, "Product 64", 84m },
                    { 63, 1, "Product 63", 83m },
                    { 62, 2, "Product 62", 82m },
                    { 61, 3, "Product 61", 81m },
                    { 60, 5, "Product 60", 80m },
                    { 59, 2, "Product 59", 79m },
                    { 58, 3, "Product 58", 78m },
                    { 57, 3, "Product 57", 77m },
                    { 56, 1, "Product 56", 76m },
                    { 55, 4, "Product 55", 75m },
                    { 54, 4, "Product 54", 74m },
                    { 53, 2, "Product 53", 73m },
                    { 74, 1, "Product 74", 94m },
                    { 52, 5, "Product 52", 72m },
                    { 75, 4, "Product 75", 95m },
                    { 77, 1, "Product 77", 97m },
                    { 98, 1, "Product 98", 118m },
                    { 97, 5, "Product 97", 117m },
                    { 96, 4, "Product 96", 116m },
                    { 95, 5, "Product 95", 115m },
                    { 94, 1, "Product 94", 114m },
                    { 93, 2, "Product 93", 113m },
                    { 92, 5, "Product 92", 112m },
                    { 91, 4, "Product 91", 111m },
                    { 90, 1, "Product 90", 110m },
                    { 89, 4, "Product 89", 109m },
                    { 88, 2, "Product 88", 108m },
                    { 87, 2, "Product 87", 107m },
                    { 86, 1, "Product 86", 106m },
                    { 85, 4, "Product 85", 105m },
                    { 84, 3, "Product 84", 104m },
                    { 83, 4, "Product 83", 103m },
                    { 82, 4, "Product 82", 102m },
                    { 81, 2, "Product 81", 101m },
                    { 80, 3, "Product 80", 100m },
                    { 79, 1, "Product 79", 99m },
                    { 78, 4, "Product 78", 98m },
                    { 76, 5, "Product 76", 96m },
                    { 51, 1, "Product 51", 71m },
                    { 50, 4, "Product 50", 70m },
                    { 49, 2, "Product 49", 69m },
                    { 22, 3, "Product 22", 42m },
                    { 21, 5, "Product 21", 41m },
                    { 20, 4, "Product 20", 40m },
                    { 19, 3, "Product 19", 39m },
                    { 18, 2, "Product 18", 38m },
                    { 17, 2, "Product 17", 37m },
                    { 16, 5, "Product 16", 36m },
                    { 15, 3, "Product 15", 35m },
                    { 14, 3, "Product 14", 34m },
                    { 13, 5, "Product 13", 33m },
                    { 12, 2, "Product 12", 32m },
                    { 11, 2, "Product 11", 31m },
                    { 10, 5, "Product 10", 30m },
                    { 9, 4, "Product 9", 29m },
                    { 8, 2, "Product 8", 28m },
                    { 7, 3, "Product 7", 27m },
                    { 6, 4, "Product 6", 26m },
                    { 5, 1, "Product 5", 25m },
                    { 4, 5, "Product 4", 24m },
                    { 3, 2, "Product 3", 23m },
                    { 2, 3, "Product 2", 22m },
                    { 23, 5, "Product 23", 43m },
                    { 24, 5, "Product 24", 44m },
                    { 25, 3, "Product 25", 45m },
                    { 26, 2, "Product 26", 46m },
                    { 48, 3, "Product 48", 68m },
                    { 47, 1, "Product 47", 67m },
                    { 46, 1, "Product 46", 66m },
                    { 45, 5, "Product 45", 65m },
                    { 44, 1, "Product 44", 64m },
                    { 43, 2, "Product 43", 63m },
                    { 42, 5, "Product 42", 62m },
                    { 41, 1, "Product 41", 61m },
                    { 40, 2, "Product 40", 60m },
                    { 39, 5, "Product 39", 59m },
                    { 99, 2, "Product 99", 119m },
                    { 38, 3, "Product 38", 58m },
                    { 36, 2, "Product 36", 56m },
                    { 35, 2, "Product 35", 55m },
                    { 34, 2, "Product 34", 54m },
                    { 33, 1, "Product 33", 53m },
                    { 32, 3, "Product 32", 52m },
                    { 31, 5, "Product 31", 51m },
                    { 30, 4, "Product 30", 50m },
                    { 29, 2, "Product 29", 49m },
                    { 28, 1, "Product 28", 48m },
                    { 27, 1, "Product 27", 47m },
                    { 37, 2, "Product 37", 57m },
                    { 100, 1, "Product 100", 120m }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "ProductImageId", "ImageUrl", "IsThumbnail", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://via.placeholder.com/150", true, 1 },
                    { 73, "https://via.placeholder.com/150", true, 73 },
                    { 72, "https://via.placeholder.com/150", true, 72 },
                    { 71, "https://via.placeholder.com/150", true, 71 },
                    { 70, "https://via.placeholder.com/150", true, 70 },
                    { 69, "https://via.placeholder.com/150", true, 69 },
                    { 68, "https://via.placeholder.com/150", true, 68 },
                    { 67, "https://via.placeholder.com/150", true, 67 },
                    { 66, "https://via.placeholder.com/150", true, 66 },
                    { 65, "https://via.placeholder.com/150", true, 65 },
                    { 64, "https://via.placeholder.com/150", true, 64 },
                    { 63, "https://via.placeholder.com/150", true, 63 },
                    { 62, "https://via.placeholder.com/150", true, 62 },
                    { 61, "https://via.placeholder.com/150", true, 61 },
                    { 60, "https://via.placeholder.com/150", true, 60 },
                    { 59, "https://via.placeholder.com/150", true, 59 },
                    { 58, "https://via.placeholder.com/150", true, 58 },
                    { 57, "https://via.placeholder.com/150", true, 57 },
                    { 56, "https://via.placeholder.com/150", true, 56 },
                    { 55, "https://via.placeholder.com/150", true, 55 },
                    { 54, "https://via.placeholder.com/150", true, 54 },
                    { 53, "https://via.placeholder.com/150", true, 53 },
                    { 74, "https://via.placeholder.com/150", true, 74 },
                    { 52, "https://via.placeholder.com/150", true, 52 },
                    { 75, "https://via.placeholder.com/150", true, 75 },
                    { 77, "https://via.placeholder.com/150", true, 77 },
                    { 98, "https://via.placeholder.com/150", true, 98 },
                    { 97, "https://via.placeholder.com/150", true, 97 },
                    { 96, "https://via.placeholder.com/150", true, 96 },
                    { 95, "https://via.placeholder.com/150", true, 95 },
                    { 94, "https://via.placeholder.com/150", true, 94 },
                    { 93, "https://via.placeholder.com/150", true, 93 },
                    { 92, "https://via.placeholder.com/150", true, 92 },
                    { 91, "https://via.placeholder.com/150", true, 91 },
                    { 90, "https://via.placeholder.com/150", true, 90 },
                    { 89, "https://via.placeholder.com/150", true, 89 },
                    { 88, "https://via.placeholder.com/150", true, 88 },
                    { 87, "https://via.placeholder.com/150", true, 87 },
                    { 86, "https://via.placeholder.com/150", true, 86 },
                    { 85, "https://via.placeholder.com/150", true, 85 },
                    { 84, "https://via.placeholder.com/150", true, 84 },
                    { 83, "https://via.placeholder.com/150", true, 83 },
                    { 82, "https://via.placeholder.com/150", true, 82 },
                    { 81, "https://via.placeholder.com/150", true, 81 },
                    { 80, "https://via.placeholder.com/150", true, 80 },
                    { 79, "https://via.placeholder.com/150", true, 79 },
                    { 78, "https://via.placeholder.com/150", true, 78 },
                    { 76, "https://via.placeholder.com/150", true, 76 },
                    { 51, "https://via.placeholder.com/150", true, 51 },
                    { 50, "https://via.placeholder.com/150", true, 50 },
                    { 49, "https://via.placeholder.com/150", true, 49 },
                    { 22, "https://via.placeholder.com/150", true, 22 },
                    { 21, "https://via.placeholder.com/150", true, 21 },
                    { 20, "https://via.placeholder.com/150", true, 20 },
                    { 19, "https://via.placeholder.com/150", true, 19 },
                    { 18, "https://via.placeholder.com/150", true, 18 },
                    { 17, "https://via.placeholder.com/150", true, 17 },
                    { 16, "https://via.placeholder.com/150", true, 16 },
                    { 15, "https://via.placeholder.com/150", true, 15 },
                    { 14, "https://via.placeholder.com/150", true, 14 },
                    { 13, "https://via.placeholder.com/150", true, 13 },
                    { 12, "https://via.placeholder.com/150", true, 12 },
                    { 11, "https://via.placeholder.com/150", true, 11 },
                    { 10, "https://via.placeholder.com/150", true, 10 },
                    { 9, "https://via.placeholder.com/150", true, 9 },
                    { 8, "https://via.placeholder.com/150", true, 8 },
                    { 7, "https://via.placeholder.com/150", true, 7 },
                    { 6, "https://via.placeholder.com/150", true, 6 },
                    { 5, "https://via.placeholder.com/150", true, 5 },
                    { 4, "https://via.placeholder.com/150", true, 4 },
                    { 3, "https://via.placeholder.com/150", true, 3 },
                    { 2, "https://via.placeholder.com/150", true, 2 },
                    { 23, "https://via.placeholder.com/150", true, 23 },
                    { 24, "https://via.placeholder.com/150", true, 24 },
                    { 25, "https://via.placeholder.com/150", true, 25 },
                    { 26, "https://via.placeholder.com/150", true, 26 },
                    { 48, "https://via.placeholder.com/150", true, 48 },
                    { 47, "https://via.placeholder.com/150", true, 47 },
                    { 46, "https://via.placeholder.com/150", true, 46 },
                    { 45, "https://via.placeholder.com/150", true, 45 },
                    { 44, "https://via.placeholder.com/150", true, 44 },
                    { 43, "https://via.placeholder.com/150", true, 43 },
                    { 42, "https://via.placeholder.com/150", true, 42 },
                    { 41, "https://via.placeholder.com/150", true, 41 },
                    { 40, "https://via.placeholder.com/150", true, 40 },
                    { 39, "https://via.placeholder.com/150", true, 39 },
                    { 99, "https://via.placeholder.com/150", true, 99 },
                    { 38, "https://via.placeholder.com/150", true, 38 },
                    { 36, "https://via.placeholder.com/150", true, 36 },
                    { 35, "https://via.placeholder.com/150", true, 35 },
                    { 34, "https://via.placeholder.com/150", true, 34 },
                    { 33, "https://via.placeholder.com/150", true, 33 },
                    { 32, "https://via.placeholder.com/150", true, 32 },
                    { 31, "https://via.placeholder.com/150", true, 31 },
                    { 30, "https://via.placeholder.com/150", true, 30 },
                    { 29, "https://via.placeholder.com/150", true, 29 },
                    { 28, "https://via.placeholder.com/150", true, 28 },
                    { 27, "https://via.placeholder.com/150", true, 27 },
                    { 37, "https://via.placeholder.com/150", true, 37 },
                    { 100, "https://via.placeholder.com/150", true, 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "ProductImageId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);
        }
    }
}
