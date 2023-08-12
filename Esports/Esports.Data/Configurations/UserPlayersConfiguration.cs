using Esports.Data.Models;
using Esports.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Configurations
{
    public class UserPlayersConfiguration : IEntityTypeConfiguration<UserPlayers>
    {
        public void Configure(EntityTypeBuilder<UserPlayers> builder)
        {
            builder.HasData(GenerateUserPlayers());
        }

        public List<UserPlayers> GenerateUserPlayers()
        {
            List<UserPlayers> up = new List<UserPlayers>();
            up.Add(new UserPlayers
            {
                Id = 1,
                UserId = Guid.Parse("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                PlayerId = Guid.Parse("F8FEE8FC-F0EC-400A-9ADA-29E031CA6549")
            });
            up.Add(new UserPlayers
            {
                Id = 2,
                UserId = Guid.Parse("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                PlayerId = Guid.Parse("021CFF98-4879-4428-908C-7C3E8DAA9FD6")
            });
            up.Add(new UserPlayers
            {
                Id = 3,
                UserId = Guid.Parse("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                PlayerId = Guid.Parse("C622FEC6-CD1C-4EC1-9D50-B60B3C937FE9")
            });
            up.Add(new UserPlayers
            {
                Id = 4,
                UserId = Guid.Parse("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                PlayerId = Guid.Parse("AC03F7FF-FDBF-4D1D-BF84-19E8B8BCC0E5")
            });
            up.Add(new UserPlayers
            {
                Id = 5,
                UserId = Guid.Parse("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                PlayerId = Guid.Parse("7C83F5CA-6A9F-4B93-83ED-B84331F30102")
            });


            up.Add(new UserPlayers
            {
                Id = 6,
                UserId = Guid.Parse("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"),
                PlayerId = Guid.Parse("4646DF15-9DE7-4066-9D1C-D99E56B905D3")
            });
            up.Add(new UserPlayers
            {
                Id = 7,
                UserId = Guid.Parse("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"),
                PlayerId = Guid.Parse("E7FF323F-A577-4696-96C2-896413A091B9")
            });
            up.Add(new UserPlayers
            {
                Id = 8,
                UserId = Guid.Parse("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"),
                PlayerId = Guid.Parse("90668808-38ED-43FE-9ECD-95B6478F9DA0")
            });
            up.Add(new UserPlayers
            {
                Id = 9,
                UserId = Guid.Parse("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"),
                PlayerId = Guid.Parse("021CFF98-4879-4428-908C-7C3E8DAA9FD6")
            });
            up.Add(new UserPlayers
            {
                Id = 10,
                UserId = Guid.Parse("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"),
                PlayerId = Guid.Parse("069A923E-5785-4907-822D-2A3528DBD67C")
            });



            up.Add(new UserPlayers
            {
                Id = 11,
                UserId = Guid.Parse("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"),
                PlayerId = Guid.Parse("F5DC4B66-5693-4959-8102-B6967DE6EA3F")
            });
            up.Add(new UserPlayers
            {
                Id = 12,
                UserId = Guid.Parse("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"),
                PlayerId = Guid.Parse("C49D757C-AC10-4CAB-97F4-016C457803BE")
            });
            up.Add(new UserPlayers
            {
                Id = 13,
                UserId = Guid.Parse("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"),
                PlayerId = Guid.Parse("1033645C-84DB-49D8-92C0-8EA6D6EE2543")
            });
            up.Add(new UserPlayers
            {
                Id = 14,
                UserId = Guid.Parse("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"),
                PlayerId = Guid.Parse("ADB1AECB-33DD-4679-9DC0-4F7FAF93E823")
            });
            up.Add(new UserPlayers
            {
                Id = 15,
                UserId = Guid.Parse("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"),
                PlayerId = Guid.Parse("9E74A0D9-30C4-4943-8C06-F25A7C650EFF")
            });



            up.Add(new UserPlayers
            {
                Id = 16,
                UserId = Guid.Parse("07b3d80f-c301-45ae-8e59-27926862c2f5"),
                PlayerId = Guid.Parse("71C3FAC3-2923-499D-A305-D6ADA7BDCAFF")
            });
            up.Add(new UserPlayers
            {
                Id = 17,
                UserId = Guid.Parse("07b3d80f-c301-45ae-8e59-27926862c2f5"),
                PlayerId = Guid.Parse("D3163C5F-6442-4065-8AE4-CABC90FFB4FD")
            });
            up.Add(new UserPlayers
            {
                Id = 18,
                UserId = Guid.Parse("07b3d80f-c301-45ae-8e59-27926862c2f5"),
                PlayerId = Guid.Parse("7C20A846-E54A-4278-8DF1-4FB87200143E")
            });
            up.Add(new UserPlayers
            {
                Id = 19,
                UserId = Guid.Parse("07b3d80f-c301-45ae-8e59-27926862c2f5"),
                PlayerId = Guid.Parse("B3EE80D1-D284-4DF3-820F-C907454FDB46")
            });
            up.Add(new UserPlayers
            {
                Id = 20,
                UserId = Guid.Parse("07b3d80f-c301-45ae-8e59-27926862c2f5"),
                PlayerId = Guid.Parse("0D82EA42-2CA8-44F3-8667-12F6DBAADD9B")
            });


            up.Add(new UserPlayers
            {
                Id = 21,
                UserId = Guid.Parse("2405e5fe-aad2-452d-8655-5245baee9f2a"),
                PlayerId = Guid.Parse("041FB4D2-C514-4E0A-B528-C14A064B44F9")
            });
            up.Add(new UserPlayers
            {
                Id = 22,
                UserId = Guid.Parse("2405e5fe-aad2-452d-8655-5245baee9f2a"),
                PlayerId = Guid.Parse("97D56415-1DC2-4222-80E8-96D9A4B312CA")
            });
            up.Add(new UserPlayers
            {
                Id = 23,
                UserId = Guid.Parse("2405e5fe-aad2-452d-8655-5245baee9f2a"),
                PlayerId = Guid.Parse("C622FEC6-CD1C-4EC1-9D50-B60B3C937FE9")
            });
            up.Add(new UserPlayers
            {
                Id = 24,
                UserId = Guid.Parse("2405e5fe-aad2-452d-8655-5245baee9f2a"),
                PlayerId = Guid.Parse("5C3D2B6A-F302-49EB-8CAB-523F6DEBAD41")
            });
            up.Add(new UserPlayers
            {
                Id = 25,
                UserId = Guid.Parse("2405e5fe-aad2-452d-8655-5245baee9f2a"),
                PlayerId = Guid.Parse("78D522F9-1B3A-4B7B-B552-422EDB8871FE")
            });



            up.Add(new UserPlayers
            {
                Id = 26,
                UserId = Guid.Parse("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"),
                PlayerId = Guid.Parse("4646DF15-9DE7-4066-9D1C-D99E56B905D3")
            });
            up.Add(new UserPlayers
            {
                Id = 27,
                UserId = Guid.Parse("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"),
                PlayerId = Guid.Parse("AC03F7FF-FDBF-4D1D-BF84-19E8B8BCC0E5")
            });
            up.Add(new UserPlayers
            {
                Id = 28,
                UserId = Guid.Parse("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"),
                PlayerId = Guid.Parse("90668808-38ED-43FE-9ECD-95B6478F9DA0")
            });
            up.Add(new UserPlayers
            {
                Id = 29,
                UserId = Guid.Parse("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"),
                PlayerId = Guid.Parse("53029BF1-EF61-42EB-86D6-ABBB100A8E7E")
            });
            up.Add(new UserPlayers
            {
                Id = 30,
                UserId = Guid.Parse("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"),
                PlayerId = Guid.Parse("069A923E-5785-4907-822D-2A3528DBD67C")
            });




            up.Add(new UserPlayers
            {
                Id = 31,
                UserId = Guid.Parse("fda99316-de5d-45a1-a2fc-fabc5e74efbb"),
                PlayerId = Guid.Parse("041FB4D2-C514-4E0A-B528-C14A064B44F9")
            });
            up.Add(new UserPlayers
            {
                Id = 32,
                UserId = Guid.Parse("fda99316-de5d-45a1-a2fc-fabc5e74efbb"),
                PlayerId = Guid.Parse("C49D757C-AC10-4CAB-97F4-016C457803BE")
            });
            up.Add(new UserPlayers
            {
                Id = 33,
                UserId = Guid.Parse("fda99316-de5d-45a1-a2fc-fabc5e74efbb"),
                PlayerId = Guid.Parse("9566BAEB-B923-458F-87AF-686B5C024149")
            });
            up.Add(new UserPlayers
            {
                Id = 34,
                UserId = Guid.Parse("fda99316-de5d-45a1-a2fc-fabc5e74efbb"),
                PlayerId = Guid.Parse("E7FF323F-A577-4696-96C2-896413A091B9")
            });
            up.Add(new UserPlayers
            {
                Id = 35,
                UserId = Guid.Parse("fda99316-de5d-45a1-a2fc-fabc5e74efbb"),
                PlayerId = Guid.Parse("B0A8DD09-3FED-4379-971A-90A5F1CFA323")
            });


            up.Add(new UserPlayers
            {
                Id = 36,
                UserId = Guid.Parse("d6bad4f5-34a8-4313-b86f-b36b8898d130"),
                PlayerId = Guid.Parse("585A5CD0-01AA-4CFD-8CC3-B731FD3303B0")
            });
            up.Add(new UserPlayers
            {
                Id = 37,
                UserId = Guid.Parse("d6bad4f5-34a8-4313-b86f-b36b8898d130"),
                PlayerId = Guid.Parse("E97B883F-3B41-4F22-A6B1-33C11142997C")
            });
            up.Add(new UserPlayers
            {
                Id = 38,
                UserId = Guid.Parse("d6bad4f5-34a8-4313-b86f-b36b8898d130"),
                PlayerId = Guid.Parse("970B89CB-F9D6-456E-9433-D0686118E7BB")
            });
            up.Add(new UserPlayers
            {
                Id = 39,
                UserId = Guid.Parse("d6bad4f5-34a8-4313-b86f-b36b8898d130"),
                PlayerId = Guid.Parse("020BF2B5-22EF-428F-9458-90D521C60DF7")
            });
            up.Add(new UserPlayers
            {
                Id = 40,
                UserId = Guid.Parse("d6bad4f5-34a8-4313-b86f-b36b8898d130"),
                PlayerId = Guid.Parse("7C83F5CA-6A9F-4B93-83ED-B84331F30102")
            });


            up.Add(new UserPlayers
            {
                Id = 41,
                UserId = Guid.Parse("926ff209-2068-40ac-a957-a94523b2ffb5"),
                PlayerId = Guid.Parse("1FD70037-7642-4C28-A20A-68A44EFB02AF")
            });
            up.Add(new UserPlayers
            {
                Id = 42,
                UserId = Guid.Parse("926ff209-2068-40ac-a957-a94523b2ffb5"),
                PlayerId = Guid.Parse("9B0B95BF-A0B1-4EEC-B439-1C86B4DCA1E7")
            });
            up.Add(new UserPlayers
            {
                Id = 43,
                UserId = Guid.Parse("926ff209-2068-40ac-a957-a94523b2ffb5"),
                PlayerId = Guid.Parse("90668808-38ED-43FE-9ECD-95B6478F9DA0")
            });
            up.Add(new UserPlayers
            {
                Id = 44,
                UserId = Guid.Parse("926ff209-2068-40ac-a957-a94523b2ffb5"),
                PlayerId = Guid.Parse("AC03F7FF-FDBF-4D1D-BF84-19E8B8BCC0E5")
            });
            up.Add(new UserPlayers
            {
                Id = 45,
                UserId = Guid.Parse("926ff209-2068-40ac-a957-a94523b2ffb5"),
                PlayerId = Guid.Parse("78D522F9-1B3A-4B7B-B552-422EDB8871FE")
            });


            up.Add(new UserPlayers
            {
                Id = 46,
                UserId = Guid.Parse("0971c874-4d75-413a-84bf-9bb817b5227f"),
                PlayerId = Guid.Parse("1E3D0B8E-346A-4852-ABF2-D45F68A946F7")
            });
            up.Add(new UserPlayers
            {
                Id = 47,
                UserId = Guid.Parse("0971c874-4d75-413a-84bf-9bb817b5227f"),
                PlayerId = Guid.Parse("711D3C0A-A5EE-4E26-B9D7-2E77ACF3C796")
            });
            up.Add(new UserPlayers
            {
                Id = 48,
                UserId = Guid.Parse("0971c874-4d75-413a-84bf-9bb817b5227f"),
                PlayerId = Guid.Parse("9566BAEB-B923-458F-87AF-686B5C024149")
            });
            up.Add(new UserPlayers
            {
                Id = 49,
                UserId = Guid.Parse("0971c874-4d75-413a-84bf-9bb817b5227f"),
                PlayerId = Guid.Parse("5FDD66B3-5B97-47C0-9B16-0BC3C0CF3886")
            });
            up.Add(new UserPlayers
            {
                Id = 50,
                UserId = Guid.Parse("0971c874-4d75-413a-84bf-9bb817b5227f"),
                PlayerId = Guid.Parse("D512A82C-4792-486A-8C18-EACF7ACEC30A")
            });



            up.Add(new UserPlayers
            {
                Id = 51,
                UserId = Guid.Parse("aac7256f-ad4a-4634-a5a8-18f85572331a"),
                PlayerId = Guid.Parse("F19B3751-9016-4C69-86E6-683EEF3BAA37")
            });
            up.Add(new UserPlayers
            {
                Id = 52,
                UserId = Guid.Parse("aac7256f-ad4a-4634-a5a8-18f85572331a"),
                PlayerId = Guid.Parse("5C3D2B6A-F302-49EB-8CAB-523F6DEBAD41")
            });
            up.Add(new UserPlayers
            {
                Id = 53,
                UserId = Guid.Parse("aac7256f-ad4a-4634-a5a8-18f85572331a"),
                PlayerId = Guid.Parse("8E802D10-FA86-4132-9A89-D6B26E4E7341")
            });
            up.Add(new UserPlayers
            {
                Id = 54,
                UserId = Guid.Parse("aac7256f-ad4a-4634-a5a8-18f85572331a"),
                PlayerId = Guid.Parse("FE0DFD94-C516-48F7-8B7C-B1A368C27C4F")
            });
            up.Add(new UserPlayers
            {
                Id = 55,
                UserId = Guid.Parse("aac7256f-ad4a-4634-a5a8-18f85572331a"),
                PlayerId = Guid.Parse("585A5CD0-01AA-4CFD-8CC3-B731FD3303B0")
            });

            return up;
        }
    }
}
