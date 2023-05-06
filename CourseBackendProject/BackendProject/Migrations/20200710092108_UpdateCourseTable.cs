using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class UpdateCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseContents_Courses_CourseId",
                table: "CourseContents");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFeatures_Courses_CourseId",
                table: "CourseFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CourseFeatures_CourseId",
                table: "CourseFeatures");

            migrationBuilder.DropIndex(
                name: "IX_CourseContents_CourseId",
                table: "CourseContents");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseFeatures");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseContents");

            migrationBuilder.AddColumn<int>(
                name: "CourseContentId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseFeatureId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseContents_CourseContentId",
                table: "Courses",
                column: "CourseContentId",
                principalTable: "CourseContents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseFeatures_CourseFeatureId",
                table: "Courses",
                column: "CourseFeatureId",
                principalTable: "CourseFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseContents_CourseContentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseFeatures_CourseFeatureId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseContentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseFeatureId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseContentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseFeatureId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseFeatures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseContents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseFeatures_CourseId",
                table: "CourseFeatures",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseContents_CourseId",
                table: "CourseContents",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContents_Courses_CourseId",
                table: "CourseContents",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFeatures_Courses_CourseId",
                table: "CourseFeatures",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
