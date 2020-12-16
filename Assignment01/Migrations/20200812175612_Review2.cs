using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment01.Migrations
{
    public partial class Review2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewText",
                table: "Reviews",
                newName: "ReviewBody");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Reviews",
                newName: "Rating");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewBody",
                table: "Reviews",
                newName: "ReviewText");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Reviews",
                newName: "Rate");
        }
    }
}
