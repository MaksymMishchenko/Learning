using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePhoneApp.Migrations
{
    public partial class AddedCostToMobilePhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                table: "MobilePhones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "MobilePhones");
        }
    }
}
