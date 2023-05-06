using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class RelationTeacherAndSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Skills_SkillsId",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "Teachers",
                newName: "SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SkillsId",
                table: "Teachers",
                newName: "IX_Teachers_SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Skills_SkillId",
                table: "Teachers",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Skills_SkillId",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "Teachers",
                newName: "SkillsId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers",
                newName: "IX_Teachers_SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Skills_SkillsId",
                table: "Teachers",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
