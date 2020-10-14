using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class IReviewEdition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Edition",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Edition_ReviewId",
                table: "Edition",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Edition_Review_ReviewId",
                table: "Edition",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Edition_Review_ReviewId",
                table: "Edition");

            migrationBuilder.DropIndex(
                name: "IX_Edition_ReviewId",
                table: "Edition");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Edition");
        }
    }
}
