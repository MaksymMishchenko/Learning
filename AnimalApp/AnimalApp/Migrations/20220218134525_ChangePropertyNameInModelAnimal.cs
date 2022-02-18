using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalApp.Migrations
{
    public partial class ChangePropertyNameInModelAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FeedInformation_Value_Kind",
                table: "Animals",
                newName: "FoodInformation_Value_Kind");

            migrationBuilder.RenameColumn(
                name: "FeedInformation_Value_Feed",
                table: "Animals",
                newName: "FoodInformation_Value_Feed");

            migrationBuilder.RenameColumn(
                name: "FeedInformation_Key_Kind",
                table: "Animals",
                newName: "FoodInformation_Key_Kind");

            migrationBuilder.RenameColumn(
                name: "FeedInformation_Key_Feed",
                table: "Animals",
                newName: "FoodInformation_Key_Feed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodInformation_Value_Kind",
                table: "Animals",
                newName: "FeedInformation_Value_Kind");

            migrationBuilder.RenameColumn(
                name: "FoodInformation_Value_Feed",
                table: "Animals",
                newName: "FeedInformation_Value_Feed");

            migrationBuilder.RenameColumn(
                name: "FoodInformation_Key_Kind",
                table: "Animals",
                newName: "FeedInformation_Key_Kind");

            migrationBuilder.RenameColumn(
                name: "FoodInformation_Key_Feed",
                table: "Animals",
                newName: "FeedInformation_Key_Feed");
        }
    }
}
