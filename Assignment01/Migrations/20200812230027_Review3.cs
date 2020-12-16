using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment01.Migrations
{
    public partial class Review3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipeIdIncre",
                table: "Reviews");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecipeIdIncre",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);
        }
    }
}
