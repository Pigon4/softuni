using Esports.Data.Helpers;
using Esports.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            players.Add(new Players()
            {
                Id = Guid.Parse("f19b3751-9016-4c69-86e6-683eef3baa37"),
                Name = "Óscar Muñoz Jiménez",
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
                Age = 22,
                Nationality = "Polish",
                Position = "sup",
                Image = imageConverter.ConvertToByteArray("..\\Esports.Data\\Images\\lec\\fnatic\\KOI_Trymbi_2023_Split_1.png"),
                TeamId = Guid.Parse("F82A5401-0DF9-4219-A9C3-C963E1168DBF")
            });


            return players;
        }
    }
}
