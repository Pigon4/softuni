using Microsoft.EntityFrameworkCore;
using Playerdle.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playerdle.Infrastructure.Context
{
    public class PlayerdleDbContext : DbContext
    {
        public PlayerdleDbContext(DbContextOptions<PlayerdleDbContext> options) : base(options)
        {

        }

        DbSet<Player> Players { get; set; }
        DbSet<Team> Teams { get; set; }

    }
}
