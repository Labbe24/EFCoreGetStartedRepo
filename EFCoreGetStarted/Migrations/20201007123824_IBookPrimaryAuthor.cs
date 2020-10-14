using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class IBookPrimaryAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrimaryAuthorAuthorId",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_PrimaryAuthorAuthorId",
                table: "Book",
                column: "PrimaryAuthorAuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_PrimaryAuthorAuthorId",
                table: "Book",
                column: "PrimaryAuthorAuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_PrimaryAuthorAuthorId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PrimaryAuthorAuthorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PrimaryAuthorAuthorId",
                table: "Book");
        }
    }
}
