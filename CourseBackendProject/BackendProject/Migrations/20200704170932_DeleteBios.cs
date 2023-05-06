using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class DeleteBios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiosTeachers");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Teachers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pinterest",
                table: "Teachers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Teachers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Vimeo",
                table: "Teachers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Pinterest",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Vimeo",
                table: "Teachers");

            migrationBuilder.CreateTable(
                name: "BiosTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Facebook = table.Column<string>(nullable: true),
                    Pinterest = table.Column<string>(nullable: true),
                    TeachersId = table.Column<int>(nullable: false),
                    Twitter = table.Column<string>(nullable: true),
                    Vimeo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiosTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BiosTeachers_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiosTeachers_TeachersId",
                table: "BiosTeachers",
                column: "TeachersId");
        }
    }
}
