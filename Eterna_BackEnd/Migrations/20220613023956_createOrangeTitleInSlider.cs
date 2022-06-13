using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna_BackEnd.Migrations
{
    public partial class createOrangeTitleInSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrangeTitle",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrangeTitle",
                table: "Sliders");
        }
    }
}
