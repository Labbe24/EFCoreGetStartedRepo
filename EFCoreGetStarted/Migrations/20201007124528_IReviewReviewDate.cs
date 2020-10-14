using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class IReviewReviewDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReviewDate",
                table: "Review",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewDate",
                table: "Review");
        }
    }
}
