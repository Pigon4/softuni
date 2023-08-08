using Esports.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Esports.Data.Configurations
{
    public class UserTeamsConfiguration : IEntityTypeConfiguration<UserTeams>
    {
        public void Configure(EntityTypeBuilder<UserTeams> builder)
        {
            builder.HasKey(x => x.UserId);

            builder.HasOne(u => u.User)
                .WithMany(t => t.UserTeam)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
