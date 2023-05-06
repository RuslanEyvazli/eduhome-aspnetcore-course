using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class UpdateSliderandBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "SliderDescription",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SliderTitle",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SliderDescription",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "SliderTitle",
                table: "Bios");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Sliders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Sliders",
                nullable: true);
        }
    }
}
