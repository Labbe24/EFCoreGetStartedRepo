using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class IVoterReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Voter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Voter_ReviewId",
                table: "Voter",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_Review_ReviewId",
                table: "Voter",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voter_Review_ReviewId",
                table: "Voter");

            migrationBuilder.DropIndex(
                name: "IX_Voter_ReviewId",
                table: "Voter");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Voter");
        }
    }
}
