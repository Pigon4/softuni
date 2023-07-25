using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class FixedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_AspNetUsers_ApplicationUserId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Packs_PackId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropIndex(
                name: "IX_Players_ApplicationUserId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_PackId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PackId",
                table: "Players");

            migrationBuilder.CreateTable(
                name: "UserPacks",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPacks", x => new { x.UserId, x.PackId });
                    table.ForeignKey(
                        name: "FK_UserPacks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPlayers",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlayers", x => new { x.UserId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_UserPlayers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPlayers_PlayerId",
                table: "UserPlayers",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams");

            migrationBuilder.DropTable(
                name: "UserPacks");

            migrationBuilder.DropTable(
                name: "UserPlayers");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "Players",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PackId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packs_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_ApplicationUserId",
                table: "Players",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_PackId",
                table: "Players",
                column: "PackId");

            migrationBuilder.CreateIndex(
                name: "IX_Packs_ApplicationUserId",
                table: "Packs",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_AspNetUsers_ApplicationUserId",
                table: "Players",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Packs_PackId",
                table: "Players",
                column: "PackId",
                principalTable: "Packs",
                principalColumn: "Id");
        }
    }
}
