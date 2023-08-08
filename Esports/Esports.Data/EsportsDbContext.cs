using Esports.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Esports.DataModels;
using System.Reflection;

namespace Esports.Data
{

    public class EsportsDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public EsportsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Players> Players { get; set; } = null!;

        public DbSet<Teams> Teams { get; set; } = null!;

        public DbSet<UserTeams> UserTeams { get; set; } = null!;
        public DbSet<UserPacks> UserPacks { get; set; } = null!;
        public DbSet<UserPlayers> UserPlayers { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(EsportsDbContext)) ??
                                        Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(typeof(EsportsDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}