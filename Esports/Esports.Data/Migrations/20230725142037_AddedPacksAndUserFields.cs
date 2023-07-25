using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class AddedPacksAndUserFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Points",
                table: "AspNetUsers");
        }
    }
}
