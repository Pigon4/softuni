using Esports.Data.Helpers;
using Esports.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Esports.Data.Configurations
{
    public class PlayerConfiguration : IEntityTypeConfiguration<Players>
    {
        public void Configure(EntityTypeBuilder<Players> builder)
        {
            builder
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GeneratePlayers());
        }

        public List<Players> GeneratePlayers()
        {
            List<Players> players = new List<Players>();
            ImageConverter imageConverter = new ImageConverter();

            //FNATIC
            players.Add(new Players()
            {
                Id = Guid.Parse("f19b3751-9016-4c69-86e6-683eef3baa37"),
                Name = "Óscar Muñoz Jiménez",
                Nickname = "Oscarinin",
                Age = 20,
                Nationality = "Spanish",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\FNC_Oscarinin_2023_Split_1.png"),
                TeamId = Guid.Parse("F82A5401-0DF9-4219-A9C3-C963E1168DBF")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("9b0b95bf-a0b1-4eec-b439-1c86b4dca1e7"),
                Name = "Iván Martín Díaz",
                Nickname = "Razork",
                Age = 22,
                Nationality = "Spanish",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\FNC_Razork_2023_Split_1.png"),
                TeamId = Guid.Parse("F82A5401-0DF9-4219-A9C3-C963E1168DBF")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("c622fec6-cd1c-4ec1-9d50-b60b3c937fe9"),
                Name = "Marek Brázda",
                Nickname = "Humanoid",
                Age = 23,
                Nationality = "Czech",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\FNC_Humanoid_2023_Split_1.png"),
                TeamId = Guid.Parse("F82A5401-0DF9-4219-A9C3-C963E1168DBF")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("1fd70037-7642-4c28-a20a-68a44efb02af"),
                Name = "Oh Hyeon-taek",
                Nickname = "Noah",
                Age = 21,
                Nationality = "Korean",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\Z10_Noah_2023_Split_1.png"),
                TeamId = Guid.Parse("F82A5401-0DF9-4219-A9C3-C963E1168DBF")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("adb1aecb-33dd-4679-9dc0-4f7faf93e823"),
                Name = "Adrian Trybus",
                Nickname = "Trymbi",
                Age = 22,
                Nationality = "Polish",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\KOI_Trymbi_2023_Split_1.png"),
                TeamId = Guid.Parse("F82A5401-0DF9-4219-A9C3-C963E1168DBF")
            });

            //G2

            players.Add(new Players()
            {
                Id = Guid.Parse("7c83f5ca-6a9f-4b93-83ed-b84331f30102"),
                Name = "Sergen Çelik",
                Nickname = "BrokenBlade",
                Age = 23,
                Nationality = "Turkish",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\g2\\G2_BrokenBlade_2023_Split_1.png"),
                TeamId = Guid.Parse("8FDDE911-0AC5-4704-B26D-4EFABC8D033C")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("021cff98-4879-4428-908c-7c3e8daa9fd6"),
                Name = "Martin Sundelin",
                Nickname = "Yike",
                Age = 22,
                Nationality = "Swedish",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\g2\\G2_Yike_2023_Split_1.png"),
                TeamId = Guid.Parse("8FDDE911-0AC5-4704-B26D-4EFABC8D033C")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("90668808-38ed-43fe-9ecd-95b6478f9da0"),
                Name = "Rasmus Borregaard Winther",
                Nickname = "Caps",
                Age = 23,
                Nationality = "Danish",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\g2\\G2_Caps_2023_Split_1.png"),
                TeamId = Guid.Parse("8FDDE911-0AC5-4704-B26D-4EFABC8D033C")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("71c3fac3-2923-499d-a305-d6ada7bdcaff"),
                Name = "Steven Liv",
                Nickname = "Hans Sama",
                Age = 23,
                Nationality = "French",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\g2\\G2_Hans_Sama_2023_Split_1.png"),
                TeamId = Guid.Parse("8FDDE911-0AC5-4704-B26D-4EFABC8D033C")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("020bf2b5-22ef-428f-9458-90d521c60df7"),
                Name = "Mihael Mehle",
                Nickname ="MikyX",
                Age = 24,
                Nationality = "Slovenian",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\g2\\G2_Mikyx_2023_Split_1.png"),
                TeamId = Guid.Parse("8FDDE911-0AC5-4704-B26D-4EFABC8D033C")
            });

            //MAD LIONS

            players.Add(new Players()
            {
                Id = Guid.Parse("979e29a8-1a3b-43f4-b8da-de6dfc085b4f"),
                Name = "Kim Dong-hyeon",
                Nickname ="Chasy",
                Age = 22,
                Nationality = "Korean",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\madlions\\MAD_Chasy_2023_Split_1.png"),
                TeamId = Guid.Parse("FF55AFE4-6156-4CE3-B848-A1D0A7472248")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("43df832e-6269-4737-b7c9-4fd3cd243e34"),
                Name = "Javier Prades Batalla",
                Nickname = "Elyoya",
                Age = 23,
                Nationality = "Spanish",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\madlions\\MAD_Elyoya_2023_Split_1.png"),
                TeamId = Guid.Parse("FF55AFE4-6156-4CE3-B848-A1D0A7472248")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("3a4d0281-857e-4ee1-8053-f96781bae9da"),
                Name = "Yasin Dinçer",
                Nickname = "Nisqy",
                Age = 25,
                Nationality = "Belgian",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\madlions\\MAD_Nisqy_2023_Split_1.png"),
                TeamId = Guid.Parse("FF55AFE4-6156-4CE3-B848-A1D0A7472248")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("069a923e-5785-4907-822d-2a3528dbd67c"),
                Name = "Matyáš Orság",
                Nickname = "Carzzy",
                Age = 21,
                Nationality = "Czech",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\madlions\\MAD_Carzzy_2023_Split_1.png"),
                TeamId = Guid.Parse("FF55AFE4-6156-4CE3-B848-A1D0A7472248")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("5fdd66b3-5b97-47c0-9b16-0bc3c0cf3886"),
                Name = "Zdravets Iliev Galabov",
                Nickname = "Hylissang",
                Age = 28,
                Nationality = "Bulgarian",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\madlions\\MAD_Hylissang_2023_Split_1.png"),
                TeamId = Guid.Parse("FF55AFE4-6156-4CE3-B848-A1D0A7472248")
            });

            //KOI fish

            players.Add(new Players()
            {
                Id = Guid.Parse("d512a82c-4792-486a-8c18-eacf7acec30a"),
                Name = "Mathias Jensen",
                Nickname = "Szygenda",
                Age = 22,
                Nationality = "Denish",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\koi\\KOI_Szygenda_2023_Split_1.png"),
                TeamId = Guid.Parse("FEA8FD74-D07E-4521-AD82-BA2FA2C270CB")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("97d56415-1dc2-4222-80e8-96d9a4b312ca"),
                Name = "Kim Geun-seong",
                Nickname ="Malrang",
                Age = 23,
                Nationality = "Korean",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\koi\\KOI_Malrang_2023_Split_1.png"),
                TeamId = Guid.Parse("FEA8FD74-D07E-4521-AD82-BA2FA2C270CB")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("1033645c-84db-49d8-92c0-8ea6d6ee2543"),
                Name = "Emil Larsson",
                Nickname ="Larssen",
                Age = 23,
                Nationality = "Swedish",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\koi\\KOI_Larssen_2023_Split_1.png"),
                TeamId = Guid.Parse("FEA8FD74-D07E-4521-AD82-BA2FA2C270CB")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("041fb4d2-c514-4e0a-b528-c14a064b44f9"),
                Name = "Markos Stamkopoulos",
                Nickname ="Comp",
                Age = 21,
                Nationality = "Greek",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\koi\\KOI_Comp_2023_Split_1.png"),
                TeamId = Guid.Parse("FEA8FD74-D07E-4521-AD82-BA2FA2C270CB")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("86b41e53-a057-4a19-ae16-1ecb45ea9631"),
                Name = "Henk Reijenga",
                Nickname = "Advienne",
                Age = 26,
                Nationality = "Dutch",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\koi\\FNC_Advienne_2023_Split_1.png"),
                TeamId = Guid.Parse("FEA8FD74-D07E-4521-AD82-BA2FA2C270CB")
            });

            //EXCEL 

            players.Add(new Players()
            {
                Id = Guid.Parse("0d82ea42-2ca8-44f3-8667-12f6dbaadd9b"),
                Name = "Andrei Pascu",
                Nickname ="Odoamne",
                Age = 28,
                Nationality = "Romanian",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\excel\\XL_Odoamne_2023_Split_1.png"),
                TeamId = Guid.Parse("0452BB8C-4C13-400A-846E-81CFA0193185")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("fe0dfd94-c516-48f7-8b7c-b1a368c27c4f"),
                Name = "Lee Min-gyu",
                Nickname ="Peach",
                Age = 23,
                Nationality = "Korean",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\excel\\USE_Peach_2023_Split_1.png"),
                TeamId = Guid.Parse("0452BB8C-4C13-400A-846E-81CFA0193185")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("9566baeb-b923-458f-87af-686b5c024149"),
                Name = "Felix Braun",
                Nickname ="Abbedagge",
                Age = 23,
                Nationality = "Germany",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\excel\\100_Abbedagge_2022_Split_2.png"),
                TeamId = Guid.Parse("0452BB8C-4C13-400A-846E-81CFA0193185")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("f8fee8fc-f0ec-400a-9ada-29e031ca6549"),
                Name = "Patrik Jírů",
                Nickname ="Patrik",
                Age = 23,
                Nationality = "Czech",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\excel\\XL_Patrik_2023_Split_1.png"),
                TeamId = Guid.Parse("0452BB8C-4C13-400A-846E-81CFA0193185")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("417e367c-ec36-4219-9232-cce140edb8d8"),
                Name = "Dino Tot",
                Nickname ="Limit",
                Age = 25,
                Nationality = "Croatian",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\excel\\XL_LIMIT_2023_Split_2.png"),
                TeamId = Guid.Parse("0452BB8C-4C13-400A-846E-81CFA0193185")
            });

            //ASTRALIS

            players.Add(new Players()
            {
                Id = Guid.Parse("b0a8dd09-3fed-4379-971a-90a5f1cfa323"),
                Name = "Finn Wiestål",
                Nickname ="Finn",
                Age = 24,
                Nationality = "Swedish",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\astralis\\AST_Finn_2023_Split_1.png"),
                TeamId = Guid.Parse("647B6346-DD83-4CF2-AED0-222D9F104E5F")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("e97b883f-3b41-4f22-a6b1-33c11142997c"),
                Name = "Doğukan Balcı",
                Nickname ="113",
                Age = 18,
                Nationality = "Turkish",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\astralis\\AST_113_2023_Split_1.png"),
                TeamId = Guid.Parse("647B6346-DD83-4CF2-AED0-222D9F104E5F")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("970b89cb-f9d6-456e-9433-d0686118e7bb"),
                Name = "Adam Ilyasov",
                Nickname ="Lider",
                Age = 24,
                Nationality = "Norwegian",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\astralis\\AST_LIDER_2023_Split_1.png"),
                TeamId = Guid.Parse("647B6346-DD83-4CF2-AED0-222D9F104E5F")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("1b9783e1-5ab6-46c6-9c88-e8cf8d433585"),
                Name = "Kasper Kobberup",
                Nickname ="Kobbe",
                Age = 26,
                Nationality = "Danish",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\astralis\\AST_Kobbe_2023_Split_1.png"),
                TeamId = Guid.Parse("647B6346-DD83-4CF2-AED0-222D9F104E5F")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("ac03f7ff-fdbf-4d1d-bf84-19e8b8bcc0e5"),
                Name = "Lee Jeong-hoon",
                Nickname ="JeongHoon",
                Age = 23,
                Nationality = "Korean",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\astralis\\AST_JeongHoon_2023_Split_1.png"),
                TeamId = Guid.Parse("647B6346-DD83-4CF2-AED0-222D9F104E5F")
            });

            //SK GAMING

            players.Add(new Players()
            {
                Id = Guid.Parse("9e74a0d9-30c4-4943-8c06-f25a7c650eff"),
                Name = "Joel Miro Scharoll",
                Nickname ="Irrelevant",
                Age = 21,
                Nationality = "German",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\skgaming\\SK_Irrelevant_2023_Split_1.png"),
                TeamId = Guid.Parse("26011AD9-F7C3-4046-887C-2408CB5A4E92")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("d3163c5f-6442-4065-8ae4-cabc90ffb4fd"),
                Name = "Mark van Woensel",
                Nickname ="Markoon",
                Age = 21,
                Nationality = "Dutch",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\skgaming\\SK_Markoon_2023_Split_1.png"),
                TeamId = Guid.Parse("26011AD9-F7C3-4046-887C-2408CB5A4E92")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("58121bf7-37c8-4484-9d89-b967967eb185"),
                Name = "Daniel Gamani",
                Nickname ="Sertuss",
                Age = 21,
                Nationality = "German",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\skgaming\\SK_Sertuss_2023_Split_1.png"),
                TeamId = Guid.Parse("26011AD9-F7C3-4046-887C-2408CB5A4E92")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("f5dc4b66-5693-4959-8102-b6967de6ea3f"),
                Name = "Thomas Foucou",
                Nickname ="Exakick",
                Age = 19,
                Nationality = "French",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\skgaming\\SK_Exakick_2023_Split_1.png"),
                TeamId = Guid.Parse("26011AD9-F7C3-4046-887C-2408CB5A4E92")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("e7ff323f-a577-4696-96c2-896413a091b9"),
                Name = "Mads Schwartz",
                Nickname = "Doss",
                Age = 24,
                Nationality = "Danish",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\skgaming\\SK_Doss_2023_Split_1.png"),
                TeamId = Guid.Parse("26011AD9-F7C3-4046-887C-2408CB5A4E92")
            });

            //TEAM BDS

            players.Add(new Players()
            {
                Id = Guid.Parse("4646df15-9de7-4066-9d1c-d99e56b905d3"),
                Name = "Adam Maanane",
                Nickname ="Adam",
                Age = 21,
                Nationality = "French",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teambdsm\\BDS_Adam_2023_Split_1.png"),
                TeamId = Guid.Parse("79FC23D1-4FCA-4B75-A2F2-291EA4A2C777")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("711d3c0a-a5ee-4e26-b9d7-2e77acf3c796"),
                Name = "Théo Borile",
                Nickname = "Sheo",
                Age = 22,
                Nationality = "French",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teambdsm\\BDS_Sheo_2023_Split_1.png"),
                TeamId = Guid.Parse("79FC23D1-4FCA-4B75-A2F2-291EA4A2C777")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("8e802d10-fa86-4132-9a89-d6b26e4e7341"),
                Name = "Ilias Bizriken",
                Nickname ="nuc",
                Age = 20,
                Nationality = "French",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teambdsm\\BDS_nuc_2023_Split_1.png"),
                TeamId = Guid.Parse("79FC23D1-4FCA-4B75-A2F2-291EA4A2C777")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("1e3d0b8e-346a-4852-abf2-d45f68a946f7"),
                Name = "Juš Marušič",
                Nickname ="Crownie",
                Age = 25,
                Nationality = "Slovenian",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teambdsm\\BDS_Crownie_2023_Split_1.png"),
                TeamId = Guid.Parse("79FC23D1-4FCA-4B75-A2F2-291EA4A2C777")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("b3ee80d1-d284-4df3-820f-c907454fdb46"),
                Name = "Labros Papoutsakis",
                Nickname ="Labrov",
                Age = 21,
                Nationality = "Greek",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teambdsm\\BDS_Labrov_2023_Split_1.png"),
                TeamId = Guid.Parse("79FC23D1-4FCA-4B75-A2F2-291EA4A2C777")
            });

            //TEAM HERETICS

            players.Add(new Players()
            {
                Id = Guid.Parse("78d522f9-1b3a-4b7b-b552-422edb8871fe"),
                Name = "Shunsuke Murase",
                Nickname ="Evi",
                Age = 27,
                Nationality = "Japanese",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamheretics\\TH_Evi_2023_Split_1.png"),
                TeamId = Guid.Parse("9215D293-4A88-4DA2-ABFE-F5D4BF824602")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("53029bf1-ef61-42eb-86d6-abbb100a8e7e"),
                Name = "Marcin Jankowski",
                Nickname ="Jankos",
                Age = 27,
                Nationality = "Polish",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamheretics\\TH_Jankos_2023_Split_1.png"),
                TeamId = Guid.Parse("9215D293-4A88-4DA2-ABFE-F5D4BF824602")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("c6f8d47b-9c20-462a-be44-e12166ca9ae5"),
                Name = "Vincent Berrié",
                Nickname ="Vetheo",
                Age = 21,
                Nationality = "French",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamheretics\\XL_Vetheo_2023_Split_1.png"),
                TeamId = Guid.Parse("9215D293-4A88-4DA2-ABFE-F5D4BF824602")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("d97fa757-1a3e-40bc-a7ce-960d2cf9eed5"),
                Name = "Victor Lirola Tortosa",
                Nickname = "Flakked",
                Age = 22,
                Nationality = "Spanish",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamheretics\\HRTS_Flakked_2023_Split_1.png"),
                TeamId = Guid.Parse("9215D293-4A88-4DA2-ABFE-F5D4BF824602")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("5c3d2b6a-f302-49eb-8cab-523f6debad41"),
                Name = "Mertai Sari",
                Nickname ="Mersa",
                Age = 20,
                Nationality = "Greek",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamheretics\\TH_Mersa_2023_Split_1.png"),
                TeamId = Guid.Parse("9215D293-4A88-4DA2-ABFE-F5D4BF824602")
            });

            //TEAM VITALITY

            players.Add(new Players()
            {
                Id = Guid.Parse("a849caaa-e079-4401-89c7-c3651244ab85"),
                Name = "Kyeong Gyu-tae",
                Nickname ="Photon",
                Age = 21,
                Nationality = "Korean",
                Position = "top",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamvitality\\VIT_Photon_2023_Split_1.png"),
                TeamId = Guid.Parse("914C7452-CE34-4162-A7F4-C364234B17EA")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("c49d757c-ac10-4cab-97f4-016c457803be"),
                Name = "Zhou Yang-Bo",
                Nickname = "Bo",
                Age = 21,
                Nationality = "Chinese",
                Position = "jng",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamvitality\\VIT_Bo_2023_Split_1.png"),
                TeamId = Guid.Parse("914C7452-CE34-4162-A7F4-C364234B17EA")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("7c20a846-e54a-4278-8df1-4fb87200143e"),
                Name = "Luka Perković",
                Nickname = "Perkz",
                Age = 24,
                Nationality = "Croatian",
                Position = "mid",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamvitality\\VIT_Perkz_2023_Split_1.png"),
                TeamId = Guid.Parse("914C7452-CE34-4162-A7F4-C364234B17EA")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("585a5cd0-01aa-4cfd-8cc3-b731fd3303b0"),
                Name = "Elias Lipp",
                Nickname ="Upset",
                Age = 23,
                Nationality = "German",
                Position = "adc",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamvitality\\VIT_Upset_2023_Split_1.png"),
                TeamId = Guid.Parse("914C7452-CE34-4162-A7F4-C364234B17EA")
            });

            players.Add(new Players()
            {
                Id = Guid.Parse("fd06da69-48e4-427b-973c-122216d11379"),
                Name = "Norman Kaiser",
                Nickname = "Kaiser",
                Age = 24,
                Nationality = "German",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamvitality\\VIT_Kaiser_2023_Split_1.png"),
                TeamId = Guid.Parse("914C7452-CE34-4162-A7F4-C364234B17EA")
            });


            return players;
        }
    }
}
