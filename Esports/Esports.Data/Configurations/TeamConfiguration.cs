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
                Logo = converter.ConvertToByteArray("..\\..\\..\\Images\\Fnaticlogo_square.png")
                
            });

            return teams;
        }
    }
}
