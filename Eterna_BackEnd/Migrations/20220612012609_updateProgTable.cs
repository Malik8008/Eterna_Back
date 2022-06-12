using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna_BackEnd.Migrations
{
    public partial class updateProgTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Progresses");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Progresses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Progresses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Progresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Progresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Progresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
