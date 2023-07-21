using Esports.Data.Helpers;
using Esports.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Esports.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Teams>
    {
        public void Configure(EntityTypeBuilder<Teams> builder)
        {
            builder.HasMany(t => t.Players)
                .WithOne(t => t.Team)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateTeams());
        }

        public List<Teams> GenerateTeams()
        {
            List<Teams> teams = new List<Teams>();
            ImageConverter converter = new ImageConverter();
            

            teams.Add(new Teams
            {
                Id = Guid.Parse("f82a5401-0df9-4219-a9c3-c963e1168dbf"),
                Name = "Fnatic",
                CountryOrigin = "United Kingdom",
                Titles = 7,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\Fnaticlogo_square.png")
                
            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("8fdde911-0ac5-4704-b26d-4efabc8d033c"),
                Name = "G2",
                CountryOrigin = "Spain",
                Titles = 10,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\g2\\G2_Esportslogo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("ff55afe4-6156-4ce3-b848-a1d0a7472248"),
                Name = "Mad Lions",
                CountryOrigin = "Spain",
                Titles = 3,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\madlions\\MAD_Lionslogo_square.png" )

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("fea8fd74-d07e-4521-ad82-ba2fa2c270cb"),
                Name = "KOI",
                CountryOrigin = "Spain",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\koi\\KOI_logo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("0452bb8c-4c13-400a-846e-81cfa0193185"),
                Name = "Excel",
                CountryOrigin = "United Kingdom",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\excel\\Excel_Esportslogo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("647b6346-dd83-4cf2-aed0-222d9f104e5f"),
                Name = "Astralis",
                CountryOrigin = "Denmark",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\astralis\\Astralislogo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("79fc23d1-4fca-4b75-a2f2-291ea4a2c777"),
                Name = "Team BDS",
                CountryOrigin = "Switzerland",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teambdsm\\Team_BDSlogo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("26011ad9-f7c3-4046-887c-2408cb5a4e92"),
                Name = "SK Gaming",
                CountryOrigin = "Germany",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\skgaming\\SK_Gaminglogo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("9215d293-4a88-4da2-abfe-f5d4bf824602"),
                Name = "Team Heretics",
                CountryOrigin = "Spain",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamheretics\\Team_Hereticslogo_square.png")

            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("914c7452-ce34-4162-a7f4-c364234b17ea"),
                Name = "Team Vitality",
                CountryOrigin = "France",
                Titles = 0,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\teamvitality\\Team_Vitalitylogo_square.png")

            });

            return teams;
        }
    }
}
