using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class BookNextInSeries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NextInSeriesBookId",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_NextInSeriesBookId",
                table: "Book",
                column: "NextInSeriesBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Book_NextInSeriesBookId",
                table: "Book",
                column: "NextInSeriesBookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Book_NextInSeriesBookId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_NextInSeriesBookId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "NextInSeriesBookId",
                table: "Book");
        }
    }
}
