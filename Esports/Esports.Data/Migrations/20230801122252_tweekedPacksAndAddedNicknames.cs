using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class tweekedPacksAndAddedNicknames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasClaimedFreePack",
                table: "UserPacks");

            migrationBuilder.AddColumn<string>(
                name: "Nickname",
                table: "Players",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasClaimedFreeReward",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("020bf2b5-22ef-428f-9458-90d521c60df7"),
                column: "Nickname",
                value: "MikyX");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("021cff98-4879-4428-908c-7c3e8daa9fd6"),
                column: "Nickname",
                value: "Yike");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("041fb4d2-c514-4e0a-b528-c14a064b44f9"),
                column: "Nickname",
                value: "Comp");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("069a923e-5785-4907-822d-2a3528dbd67c"),
                column: "Nickname",
                value: "Carzzy");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("0d82ea42-2ca8-44f3-8667-12f6dbaadd9b"),
                column: "Nickname",
                value: "Odoamne");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1033645c-84db-49d8-92c0-8ea6d6ee2543"),
                column: "Nickname",
                value: "Larssen");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1b9783e1-5ab6-46c6-9c88-e8cf8d433585"),
                column: "Nickname",
                value: "Kobbe");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1e3d0b8e-346a-4852-abf2-d45f68a946f7"),
                column: "Nickname",
                value: "Crownie");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("1fd70037-7642-4c28-a20a-68a44efb02af"),
                column: "Nickname",
                value: "Noah");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("3a4d0281-857e-4ee1-8053-f96781bae9da"),
                column: "Nickname",
                value: "Nisqy");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("417e367c-ec36-4219-9232-cce140edb8d8"),
                column: "Nickname",
                value: "Limit");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("43df832e-6269-4737-b7c9-4fd3cd243e34"),
                column: "Nickname",
                value: "Elyoya");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("4646df15-9de7-4066-9d1c-d99e56b905d3"),
                column: "Nickname",
                value: "Adam");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("53029bf1-ef61-42eb-86d6-abbb100a8e7e"),
                column: "Nickname",
                value: "Jankos");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("58121bf7-37c8-4484-9d89-b967967eb185"),
                column: "Nickname",
                value: "Sertuss");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("585a5cd0-01aa-4cfd-8cc3-b731fd3303b0"),
                column: "Nickname",
                value: "Upset");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("5c3d2b6a-f302-49eb-8cab-523f6debad41"),
                column: "Nickname",
                value: "Mersa");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("5fdd66b3-5b97-47c0-9b16-0bc3c0cf3886"),
                column: "Nickname",
                value: "Hylissang");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("711d3c0a-a5ee-4e26-b9d7-2e77acf3c796"),
                column: "Nickname",
                value: "Sheo");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("71c3fac3-2923-499d-a305-d6ada7bdcaff"),
                column: "Nickname",
                value: "Hans Sama");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("78d522f9-1b3a-4b7b-b552-422edb8871fe"),
                column: "Nickname",
                value: "Evi");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7c20a846-e54a-4278-8df1-4fb87200143e"),
                column: "Nickname",
                value: "Perkz");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("7c83f5ca-6a9f-4b93-83ed-b84331f30102"),
                column: "Nickname",
                value: "BrokenBlade");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("86b41e53-a057-4a19-ae16-1ecb45ea9631"),
                column: "Nickname",
                value: "Advienne");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("8e802d10-fa86-4132-9a89-d6b26e4e7341"),
                column: "Nickname",
                value: "nuc");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("90668808-38ed-43fe-9ecd-95b6478f9da0"),
                column: "Nickname",
                value: "Caps");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9566baeb-b923-458f-87af-686b5c024149"),
                column: "Nickname",
                value: "Abbedagge");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("970b89cb-f9d6-456e-9433-d0686118e7bb"),
                column: "Nickname",
                value: "Lider");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("979e29a8-1a3b-43f4-b8da-de6dfc085b4f"),
                column: "Nickname",
                value: "Chasy");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("97d56415-1dc2-4222-80e8-96d9a4b312ca"),
                column: "Nickname",
                value: "Malrang");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9b0b95bf-a0b1-4eec-b439-1c86b4dca1e7"),
                column: "Nickname",
                value: "Razork");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9e74a0d9-30c4-4943-8c06-f25a7c650eff"),
                column: "Nickname",
                value: "Irrelevant");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("a849caaa-e079-4401-89c7-c3651244ab85"),
                column: "Nickname",
                value: "Photon");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ac03f7ff-fdbf-4d1d-bf84-19e8b8bcc0e5"),
                column: "Nickname",
                value: "JeongHoon");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("adb1aecb-33dd-4679-9dc0-4f7faf93e823"),
                column: "Nickname",
                value: "Trymbi");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("b0a8dd09-3fed-4379-971a-90a5f1cfa323"),
                column: "Nickname",
                value: "Finn");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("b3ee80d1-d284-4df3-820f-c907454fdb46"),
                column: "Nickname",
                value: "Labrov");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c49d757c-ac10-4cab-97f4-016c457803be"),
                column: "Nickname",
                value: "Bo");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c622fec6-cd1c-4ec1-9d50-b60b3c937fe9"),
                column: "Nickname",
                value: "Humanoid");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c6f8d47b-9c20-462a-be44-e12166ca9ae5"),
                column: "Nickname",
                value: "Vetheo");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("d3163c5f-6442-4065-8ae4-cabc90ffb4fd"),
                column: "Nickname",
                value: "Markoon");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("d512a82c-4792-486a-8c18-eacf7acec30a"),
                column: "Nickname",
                value: "Szygenda");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("d97fa757-1a3e-40bc-a7ce-960d2cf9eed5"),
                column: "Nickname",
                value: "Flakked");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e7ff323f-a577-4696-96c2-896413a091b9"),
                column: "Nickname",
                value: "Doss");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e97b883f-3b41-4f22-a6b1-33c11142997c"),
                column: "Nickname",
                value: "113");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("f19b3751-9016-4c69-86e6-683eef3baa37"),
                column: "Nickname",
                value: "Oscarinin");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("f5dc4b66-5693-4959-8102-b6967de6ea3f"),
                column: "Nickname",
                value: "Exakick");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("f8fee8fc-f0ec-400a-9ada-29e031ca6549"),
                column: "Nickname",
                value: "Patrik");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("fd06da69-48e4-427b-973c-122216d11379"),
                column: "Nickname",
                value: "Kaiser");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("fe0dfd94-c516-48f7-8b7c-b1a368c27c4f"),
                column: "Nickname",
                value: "Peach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nickname",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "HasClaimedFreeReward",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "HasClaimedFreePack",
                table: "UserPacks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
