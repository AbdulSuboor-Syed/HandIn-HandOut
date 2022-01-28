using Microsoft.EntityFrameworkCore.Migrations;

namespace HandInHandOut.Migrations
{
    public partial class SeedBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "Author", "BuyingAmount", "IsAvailable", "Major", "Name", "NumberOfBooksAvailable", "RentingAmount" },
                values: new object[] { 1, "Syed Abdul Suboor", 12.99, 0, 1, "C# For Dummies", 20, 0.20000000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
