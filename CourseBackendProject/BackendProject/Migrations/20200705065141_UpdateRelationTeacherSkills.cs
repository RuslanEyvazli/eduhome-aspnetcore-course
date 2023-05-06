using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class UpdateRelationTeacherSkills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSkills");

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SkillsId",
                table: "Teachers",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Skills_SkillsId",
                table: "Teachers",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Skills_SkillsId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SkillsId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "Teachers");

            migrationBuilder.CreateTable(
                name: "TeacherSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkillsId = table.Column<int>(nullable: false),
                    TeachersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSkills_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSkills_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_SkillsId",
                table: "TeacherSkills",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSkills_TeachersId",
                table: "TeacherSkills",
                column: "TeachersId");
        }
    }
}
