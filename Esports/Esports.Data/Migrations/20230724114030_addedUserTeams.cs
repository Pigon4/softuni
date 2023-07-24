using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class addedUserTeams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTeams",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JngId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MidId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdcId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTeams", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTeams");
        }
    }
}
