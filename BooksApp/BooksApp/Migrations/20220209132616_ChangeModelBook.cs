using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksApp.Migrations
{
    public partial class ChangeModelBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishHouse",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublishHouseId",
                table: "Books",
                column: "PublishHouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_PublishHouse_PublishHouseId",
                table: "Books",
                column: "PublishHouseId",
                principalTable: "PublishHouse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_PublishHouse_PublishHouseId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublishHouseId",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "PublishHouse",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
