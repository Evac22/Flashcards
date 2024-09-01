using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flashcards.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Categories_CategoryId",
                table: "Decks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlashcardTag_Flashcards_FlashcardId",
                table: "FlashcardTag");

            migrationBuilder.DropForeignKey(
                name: "FK_FlashcardTag_Tags_TagId",
                table: "FlashcardTag");

            migrationBuilder.DropIndex(
                name: "IX_Decks_CategoryId",
                table: "Decks");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Flashcards");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Decks");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Decks");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "FlashcardTag",
                newName: "TagsId");

            migrationBuilder.RenameColumn(
                name: "FlashcardId",
                table: "FlashcardTag",
                newName: "FlashcardsId");

            migrationBuilder.RenameIndex(
                name: "IX_FlashcardTag_TagId",
                table: "FlashcardTag",
                newName: "IX_FlashcardTag_TagsId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Flashcards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Flashcards_CategoryId",
                table: "Flashcards",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flashcards_Categories_CategoryId",
                table: "Flashcards",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlashcardTag_Flashcards_FlashcardsId",
                table: "FlashcardTag",
                column: "FlashcardsId",
                principalTable: "Flashcards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlashcardTag_Tags_TagsId",
                table: "FlashcardTag",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flashcards_Categories_CategoryId",
                table: "Flashcards");

            migrationBuilder.DropForeignKey(
                name: "FK_FlashcardTag_Flashcards_FlashcardsId",
                table: "FlashcardTag");

            migrationBuilder.DropForeignKey(
                name: "FK_FlashcardTag_Tags_TagsId",
                table: "FlashcardTag");

            migrationBuilder.DropIndex(
                name: "IX_Flashcards_CategoryId",
                table: "Flashcards");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Flashcards");

            migrationBuilder.RenameColumn(
                name: "TagsId",
                table: "FlashcardTag",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "FlashcardsId",
                table: "FlashcardTag",
                newName: "FlashcardId");

            migrationBuilder.RenameIndex(
                name: "IX_FlashcardTag_TagsId",
                table: "FlashcardTag",
                newName: "IX_FlashcardTag_TagId");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Flashcards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Decks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Decks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_CategoryId",
                table: "Decks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Categories_CategoryId",
                table: "Decks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlashcardTag_Flashcards_FlashcardId",
                table: "FlashcardTag",
                column: "FlashcardId",
                principalTable: "Flashcards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlashcardTag_Tags_TagId",
                table: "FlashcardTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
