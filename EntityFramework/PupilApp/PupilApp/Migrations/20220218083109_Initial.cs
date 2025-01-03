using Microsoft.EntityFrameworkCore.Migrations;

namespace PupilApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pupils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Success",
                columns: table => new
                {
                    ClassRoomsId = table.Column<int>(type: "int", nullable: false),
                    PupilsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Success", x => new { x.ClassRoomsId, x.PupilsId });
                    table.ForeignKey(
                        name: "FK_Success_ClassRooms_ClassRoomsId",
                        column: x => x.ClassRoomsId,
                        principalTable: "ClassRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Success_Pupils_PupilsId",
                        column: x => x.PupilsId,
                        principalTable: "Pupils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Success_PupilsId",
                table: "Success",
                column: "PupilsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Success");

            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Pupils");
        }
    }
}
