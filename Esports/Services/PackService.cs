using Esports.Data;
using Esports.Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PackService : IPackSevice
    {
        private readonly EsportsDbContext _context;

        public PackService(EsportsDbContext context)
        {
            _context = context;
        }
        public async Task<List<Players>> GetStarterPackAsync()
        {
            List<Players> players = new List<Players>();
                Random rnd = new Random();
                int number = rnd.Next(0,10);
            players.Add(_context.Players.Where(x => x.Position == "top")
                .ToList()[number]);
            players.Add(_context.Players.Where(x => x.Position == "jng")
                .ToList()[number]);
            players.Add(_context.Players.Where(x => x.Position == "mid")
                .ToList()[number]);
            players.Add(_context.Players.Where(x => x.Position == "adc")
                .ToList()[number]);
            players.Add(_context.Players.Where(x => x.Position == "sup")
                .ToList()[number]);


            return players;
        }
    }
}
