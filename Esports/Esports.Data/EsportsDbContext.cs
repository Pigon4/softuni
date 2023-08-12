using Esports.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Esports.DataModels;
using System.Reflection;
using Esports.Data.Configurations;

namespace Esports.Data
{

    public class EsportsDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public EsportsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; } = null!;

        public DbSet<Team> Teams { get; set; } = null!;

        public DbSet<UserTeams> UserTeams { get; set; } = null!;
        public DbSet<UserPacks> UserPacks { get; set; } = null!;
        public DbSet<UserPlayers> UserPlayers { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PlayerConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserPlayersConfiguration());


            base.OnModelCreating(builder);
        }
    }
}