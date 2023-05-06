using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class AddDal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSpikers_Speaker_SpeakerId",
                table: "EventSpikers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker");

            migrationBuilder.RenameTable(
                name: "Speaker",
                newName: "Speakers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpikers_Speakers_SpeakerId",
                table: "EventSpikers",
                column: "SpeakerId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSpikers_Speakers_SpeakerId",
                table: "EventSpikers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speakers",
                table: "Speakers");

            migrationBuilder.RenameTable(
                name: "Speakers",
                newName: "Speaker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speaker",
                table: "Speaker",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpikers_Speaker_SpeakerId",
                table: "EventSpikers",
                column: "SpeakerId",
                principalTable: "Speaker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
