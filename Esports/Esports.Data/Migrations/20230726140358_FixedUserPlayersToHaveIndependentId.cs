using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class FixedUserPlayersToHaveIndependentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPlayers",
                table: "UserPlayers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPlayers",
                table: "UserPlayers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlayers_UserId",
                table: "UserPlayers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPlayers",
                table: "UserPlayers");

            migrationBuilder.DropIndex(
                name: "IX_UserPlayers_UserId",
                table: "UserPlayers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserPlayers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPlayers",
                table: "UserPlayers",
                columns: new[] { "UserId", "PlayerId" });
        }
    }
}
