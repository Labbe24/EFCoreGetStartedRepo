using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class IIsbnToIsbn10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Isbn10",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isbn10",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
