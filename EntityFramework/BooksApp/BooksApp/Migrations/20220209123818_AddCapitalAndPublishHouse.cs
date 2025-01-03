using Microsoft.EntityFrameworkCore.Migrations;

namespace BooksApp.Migrations
{
    public partial class AddCapitalAndPublishHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CapitalId",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublishHouse",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublishHouseId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PublishHouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Capitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishHouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Capitals_PublishHouse_PublishHouseId",
                        column: x => x.PublishHouseId,
                        principalTable: "PublishHouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CapitalId",
                table: "Countries",
                column: "CapitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Capitals_PublishHouseId",
                table: "Capitals",
                column: "PublishHouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Capitals_CapitalId",
                table: "Countries",
                column: "CapitalId",
                principalTable: "Capitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Capitals_CapitalId",
                table: "Countries");

            migrationBuilder.DropTable(
                name: "Capitals");

            migrationBuilder.DropTable(
                name: "PublishHouse");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CapitalId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CapitalId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "PublishHouse",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishHouseId",
                table: "Books");
        }
    }
}
