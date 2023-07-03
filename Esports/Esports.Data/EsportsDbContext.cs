using Esports.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Esports.DataModels;

namespace Esports.Data
{

    public class EsportsDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public EsportsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Players> Players { get; set; } = null!;

        public DbSet<Teams> Teams { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}