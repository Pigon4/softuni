using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class seededPlayerTeamAndUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasClaimedFreeReward", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Points", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"), 0, "6f165fbc-7a34-44f8-b3fe-ce7654d629d2", "lachezar10@abv.bg", false, true, false, null, "LACHEZAR10@ABV.BG", "PIGON", "AQAAAAEAACcQAAAAEAXIi+0DigWj2nGxbuHM/LUWTozxhBepsjSnvNqIaWEtLsch5HNc89c0duB+/ilWmA==", null, false, 44, "d48794d3-c1fa-4cab-8260-b8f1340a97b5", false, "Pigon" });

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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"));

            migrationBuilder.AddForeignKey(
                name: "FK_UserTeams_AspNetUsers_UserId",
                table: "UserTeams",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
