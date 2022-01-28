using Microsoft.EntityFrameworkCore.Migrations;

namespace HandInHandOut.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<int>(type: "int", nullable: false),
                    BuyingAmount = table.Column<double>(type: "float", nullable: false),
                    RentingAmount = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<int>(type: "int", nullable: false),
                    NumberOfBooksAvailable = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
