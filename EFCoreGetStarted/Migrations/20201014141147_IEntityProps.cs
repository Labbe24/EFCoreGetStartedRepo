using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreGetStarted.Migrations
{
    public partial class IEntityProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Book_NextInSeriesBookId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_PrimaryAuthorAuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Author_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_Edition_Book_BookId",
                table: "Edition");

            migrationBuilder.DropForeignKey(
                name: "FK_Edition_Review_ReviewId",
                table: "Edition");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceOffer_Book_BookId",
                table: "PriceOffer");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Book_BookId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Voter_Review_ReviewId",
                table: "Voter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voter",
                table: "Voter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceOffer",
                table: "PriceOffer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Edition",
                table: "Edition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Voter",
                newName: "Voters");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "PriceOffer",
                newName: "PriceOffers");

            migrationBuilder.RenameTable(
                name: "Edition",
                newName: "Editions");

            migrationBuilder.RenameTable(
                name: "BookAuthor",
                newName: "BookAuthors");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.RenameIndex(
                name: "IX_Voter_ReviewId",
                table: "Voters",
                newName: "IX_Voters_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_BookId",
                table: "Reviews",
                newName: "IX_Reviews_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceOffer_BookId",
                table: "PriceOffers",
                newName: "IX_PriceOffers_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Edition_ReviewId",
                table: "Editions",
                newName: "IX_Editions_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Edition_BookId",
                table: "Editions",
                newName: "IX_Editions_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthors",
                newName: "IX_BookAuthors_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PrimaryAuthorAuthorId",
                table: "Books",
                newName: "IX_Books_PrimaryAuthorAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_NextInSeriesBookId",
                table: "Books",
                newName: "IX_Books_NextInSeriesBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voters",
                table: "Voters",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceOffers",
                table: "PriceOffers",
                column: "PriceOfferId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                table: "Editions",
                column: "EditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Books_NextInSeriesBookId",
                table: "Books",
                column: "NextInSeriesBookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_PrimaryAuthorAuthorId",
                table: "Books",
                column: "PrimaryAuthorAuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Books_BookId",
                table: "Editions",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Editions_Reviews_ReviewId",
                table: "Editions",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceOffers_Books_BookId",
                table: "PriceOffers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Reviews_ReviewId",
                table: "Voters",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Authors_AuthorId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthors_Books_BookId",
                table: "BookAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Books_NextInSeriesBookId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_PrimaryAuthorAuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Books_BookId",
                table: "Editions");

            migrationBuilder.DropForeignKey(
                name: "FK_Editions_Reviews_ReviewId",
                table: "Editions");

            migrationBuilder.DropForeignKey(
                name: "FK_PriceOffers_Books_BookId",
                table: "PriceOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BookId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Reviews_ReviewId",
                table: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voters",
                table: "Voters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PriceOffers",
                table: "PriceOffers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Voters",
                newName: "Voter");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "PriceOffers",
                newName: "PriceOffer");

            migrationBuilder.RenameTable(
                name: "Editions",
                newName: "Edition");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "BookAuthors",
                newName: "BookAuthor");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.RenameIndex(
                name: "IX_Voters_ReviewId",
                table: "Voter",
                newName: "IX_Voter_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_BookId",
                table: "Review",
                newName: "IX_Review_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_PriceOffers_BookId",
                table: "PriceOffer",
                newName: "IX_PriceOffer_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Editions_ReviewId",
                table: "Edition",
                newName: "IX_Edition_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Editions_BookId",
                table: "Edition",
                newName: "IX_Edition_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PrimaryAuthorAuthorId",
                table: "Book",
                newName: "IX_Book_PrimaryAuthorAuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_NextInSeriesBookId",
                table: "Book",
                newName: "IX_Book_NextInSeriesBookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthor",
                newName: "IX_BookAuthor_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voter",
                table: "Voter",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PriceOffer",
                table: "PriceOffer",
                column: "PriceOfferId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Edition",
                table: "Edition",
                column: "EditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Book_NextInSeriesBookId",
                table: "Book",
                column: "NextInSeriesBookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_PrimaryAuthorAuthorId",
                table: "Book",
                column: "PrimaryAuthorAuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Author_AuthorId",
                table: "BookAuthor",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Edition_Book_BookId",
                table: "Edition",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Edition_Review_ReviewId",
                table: "Edition",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PriceOffer_Book_BookId",
                table: "PriceOffer",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Book_BookId",
                table: "Review",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voter_Review_ReviewId",
                table: "Voter",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
