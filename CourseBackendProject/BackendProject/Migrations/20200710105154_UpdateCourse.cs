using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class UpdateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseFeatureId",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses",
                column: "CourseContentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFeatureId",
                table: "Courses",
                column: "CourseFeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseFeatureId",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses",
                column: "CourseContentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFeatureId",
                table: "Courses",
                column: "CourseFeatureId",
                unique: true);
        }
    }
}
