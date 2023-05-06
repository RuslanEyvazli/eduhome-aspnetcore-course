using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class AddTeachersIdColumnBios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeachersId",
                table: "BiosTeachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BiosTeachers_TeachersId",
                table: "BiosTeachers",
                column: "TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiosTeachers_Teachers_TeachersId",
                table: "BiosTeachers",
                column: "TeachersId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiosTeachers_Teachers_TeachersId",
                table: "BiosTeachers");

            migrationBuilder.DropIndex(
                name: "IX_BiosTeachers_TeachersId",
                table: "BiosTeachers");

            migrationBuilder.DropColumn(
                name: "TeachersId",
                table: "BiosTeachers");
        }
    }
}
