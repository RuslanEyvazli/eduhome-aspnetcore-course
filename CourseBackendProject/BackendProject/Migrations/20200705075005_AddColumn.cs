using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class AddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers",
                column: "SkillId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers",
                column: "SkillId");
        }
    }
}
