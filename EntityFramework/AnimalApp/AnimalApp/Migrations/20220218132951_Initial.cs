using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FeedInformation_Key_Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedInformation_Key_Feed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedInformation_Value_Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedInformation_Value_Feed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
