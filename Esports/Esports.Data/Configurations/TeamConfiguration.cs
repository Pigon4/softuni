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
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\Fnaticlogo_square.png")
                
            });

            teams.Add(new Teams
            {
                Id = Guid.Parse("8fdde911-0ac5-4704-b26d-4efabc8d033c"),
                Name = "G2",
                CountryOrigin = "Spain",
                Titles = 10,
                Logo = converter.ConvertToByteArray("..\\Esports.Data\\Images\\G2_Esportslogo_profile.png")

            });


            return teams;
        }
    }
}
