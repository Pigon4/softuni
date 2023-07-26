using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class FixedUserPacksToBeKeyless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserPacks",
                table: "UserPacks");

            migrationBuilder.CreateIndex(
                name: "IX_UserPacks_UserId",
                table: "UserPacks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserPacks_UserId",
                table: "UserPacks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserPacks",
                table: "UserPacks",
                columns: new[] { "UserId", "PackId" });
        }
    }
}
