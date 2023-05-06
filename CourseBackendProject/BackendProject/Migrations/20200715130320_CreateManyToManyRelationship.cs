using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class CreateManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "EventSpikers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "EventSpikers");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "EventSpikers");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "EventSpikers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeakerId",
                table: "EventSpikers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fullname = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Profession = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventSpikers_EventId",
                table: "EventSpikers",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpikers_SpeakerId",
                table: "EventSpikers",
                column: "SpeakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpikers_Events_EventId",
                table: "EventSpikers",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpikers_Speaker_SpeakerId",
                table: "EventSpikers",
                column: "SpeakerId",
                principalTable: "Speaker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSpikers_Events_EventId",
                table: "EventSpikers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpikers_Speaker_SpeakerId",
                table: "EventSpikers");

            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropIndex(
                name: "IX_EventSpikers_EventId",
                table: "EventSpikers");

            migrationBuilder.DropIndex(
                name: "IX_EventSpikers_SpeakerId",
                table: "EventSpikers");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "EventSpikers");

            migrationBuilder.DropColumn(
                name: "SpeakerId",
                table: "EventSpikers");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "EventSpikers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EventSpikers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "EventSpikers",
                nullable: false,
                defaultValue: "");
        }
    }
}
