using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Esports.Data.Migrations
{
    public partial class fixedUserConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae2d2be-9766-427b-b070-0c35e2239f99", "AQAAAAEAACcQAAAAEP9Phn8q8XybZ40yV4VlMGL4PdX28kOrxUQCfyV/CQf2//evJeOvppeg2j3As88+6A==", "fb5722b3-7665-43d5-b540-67b0218cbcb1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasClaimedFreeReward", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Points", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("07b3d80f-c301-45ae-8e59-27926862c2f5"), 0, "368a7f2c-a4b2-4ac3-8d42-68089ee78558", "fncnumberone@gmail.com", false, true, false, null, "FNCNUMBERONE@GMAIL.COM", "FNCFAN", "AQAAAAEAACcQAAAAEEsVo/GNNX9nvilZW+T4NGm8ZxG1Nzl2TxtkwDLwnmgJVCh7puA3OkfPg33gTvq8gg==", null, false, 7, "c5505337-f961-4c18-a423-0eea1f02eb58", false, "FncFan" },
                    { new Guid("0971c874-4d75-413a-84bf-9bb817b5227f"), 0, "a9105c68-d924-4301-ac3e-4b79e8e4ae20", "creative@abv.bg", false, true, false, null, "CREATIVE@ABV.BG", "EXTRAVAGANTLY", "AQAAAAEAACcQAAAAEH02g6BwlzdFCcEGD4/9q8mf8NapCaM4xF2ZmQuuP2DOQSXPa5Z7HwfXE4Se0b/Sig==", null, false, 39, "95120c09-93bd-4955-9fca-a4219fcccaeb", false, "extravagantly" },
                    { new Guid("2405e5fe-aad2-452d-8655-5245baee9f2a"), 0, "846c5152-a504-4090-9f9a-f5dc54df6b84", "depression@gmail.com", false, true, false, null, "DEPRESSION@GMAIL.COM", "SADDD", "AQAAAAEAACcQAAAAECtIurWOAlBJM2Tmye3KXHVfzaFckxwKuqR3u9v04jP1ItIbiZeIwEyBI1+V/cDB9Q==", null, false, 13, "7d282930-51c8-486c-880d-6e19b79aadbc", false, "saddd" },
                    { new Guid("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"), 0, "275af5d6-4926-44e9-b1f7-dafde1314795", "Ash.aimed.15@gmail.com", false, true, false, null, "ASH.AIMED.15@GMAIL.COM", "ASH_AIMED", "AQAAAAEAACcQAAAAEPOz8h9E5zOgtsJOWBalVXIqJTbOpucZNP3wJ6NLolsLd5g5F/lv38mLR2GkTarbng==", null, false, 16, "17fa46d3-6c48-4676-8640-a3b82cec7f17", false, "Ash_aimed" },
                    { new Guid("926ff209-2068-40ac-a957-a94523b2ffb5"), 0, "3713d9b1-107c-445a-90fa-a0e3d2053aec", "pieceisreal@gmail.com", false, true, false, null, "PIECEISREAL@GMAIL.COM", "THE ONE", "AQAAAAEAACcQAAAAENc8yyVcP7F/jzuK2Cm5J1iKmY11W0f8w1dAIWHSNjmZfKcSBqhxRz6IWqTdrzqUpQ==", null, false, 1, "77206444-5370-4245-b8e7-523169fd1ed1", false, "the one" },
                    { new Guid("aac7256f-ad4a-4634-a5a8-18f85572331a"), 0, "15ecea9f-3959-4db7-b647-0166d1c31584", "Jesper_Beovarie@gmail.com", false, true, false, null, "JESPER_BEOVARIE@GMAIL.COM", "JESPER", "AQAAAAEAACcQAAAAEHDWdE/IzzuQq+8v62zg+JeGjykBX6EUQTm+kn1W9sau3oC7iRD6bbidj9TGis7DFw==", null, false, 28, "df85c31d-72e2-4707-ad68-10f6cdd40b0c", false, "Jesper" },
                    { new Guid("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"), 0, "e836cf6a-a517-44c3-b635-b95dd52ee7af", "shouldvestartearlier@gmail.com", false, true, false, null, "SHOULDVESTARTEARLIER@GMAIL.COM", "LAZY ASPERGER", "AQAAAAEAACcQAAAAEL2Hl0D6Iq7T5NnJ4ItYNld4Ps4k4aN/9OrgQ8pJTZ2MJgoOV2wLlDs5QNLf1GREIA==", null, false, 31, "8843c68a-e458-4164-9ea0-773871172af7", false, "Lazy asperger" },
                    { new Guid("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"), 0, "a5c1945a-f81a-47d0-8cb5-5712e8a1365b", "RichJer@gmail.com", false, true, false, null, "RICHJER@GMAIL.COM", "RICH JERMAINE", "AQAAAAEAACcQAAAAEI3DpZ1tJlk0Opy5YKj3+DrtM+JtFpiDRGEwpJRoYUINZubytRIct37X7EHWguH+Gw==", null, false, 25, "7a8dd60a-df3b-4cce-af17-118c44a71034", false, "rich jermaine" },
                    { new Guid("d6bad4f5-34a8-4313-b86f-b36b8898d130"), 0, "7433787d-ac1d-4753-b46d-a06efe5518b1", "Drago_Ussopp@gmail.com", false, true, false, null, "DRAGO_USSOPP@GMAIL.COM", "DU44", "AQAAAAEAACcQAAAAEHD3BWebZS4pE85xAggCx1RtgLnUIKck8MiFds0Xv0XQrTEfY0n149wunDjbML3RRQ==", null, false, 18, "c150ad19-879c-41e7-b90e-92bd573c9e69", false, "du44" },
                    { new Guid("fda99316-de5d-45a1-a2fc-fabc5e74efbb"), 0, "7b3fe930-f11c-4adb-b9e6-6ef72c179e1f", "Brezhovica@yahoo.com", false, true, false, null, "BREZHOVICA@YAHOO.COM", "BREZHO", "AQAAAAEAACcQAAAAEC0uuXkHzEEhbrnsCHU2UprS+x182q7hnNG4m5NicYohLpmx9nfMOgWI5wIAtUodSw==", null, false, 34, "45feb0f5-079e-4094-a643-84d24f344048", false, "Brezho" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("07b3d80f-c301-45ae-8e59-27926862c2f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0971c874-4d75-413a-84bf-9bb817b5227f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2405e5fe-aad2-452d-8655-5245baee9f2a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("926ff209-2068-40ac-a957-a94523b2ffb5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aac7256f-ad4a-4634-a5a8-18f85572331a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6bad4f5-34a8-4313-b86f-b36b8898d130"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fda99316-de5d-45a1-a2fc-fabc5e74efbb"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f165fbc-7a34-44f8-b3fe-ce7654d629d2", "AQAAAAEAACcQAAAAEAXIi+0DigWj2nGxbuHM/LUWTozxhBepsjSnvNqIaWEtLsch5HNc89c0duB+/ilWmA==", "d48794d3-c1fa-4cab-8260-b8f1340a97b5" });
        }
    }
}
