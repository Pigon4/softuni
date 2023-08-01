using Esports.Data;
using Esports.Data.Models;
using Esports.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using ViewModels;

namespace Esports.Services
{
    public class PacksService : IPackService
    {
        private EsportsDbContext _context;

        public PacksService(EsportsDbContext context)
        {
            _context = context;
        }

        public async Task<List<int>> GetAllPacksByUserIdAsync(Guid UserId)
        {
            List<int> packIds = new List<int>();
            foreach (var item in await _context.UserPacks.Where(x => x.UserId == UserId).ToListAsync())
            {
                packIds.Add(item.PackId);
            }

            return packIds;
        }

        //id = 0
        public async Task GetFreePackAsync(Guid userId)
        {
            UserPacks up = new UserPacks { UserId = userId, PackId = 0};


            _context.Users.First(x => x.Id == userId).HasClaimedFreeReward = true;

            await _context.UserPacks.AddAsync(up);
            await _context.SaveChangesAsync();

        }

        //id = 1 
        public async Task GetNormalPackAsync(Guid userId)
        {
            UserPacks up = new UserPacks { UserId = userId, PackId = 1};


            await _context.UserPacks.AddAsync(up);
            await _context.SaveChangesAsync();

        }

        public bool HasClaimedFreePack(Guid userId)
        {
            bool result = _context.Users.First(x => x.Id == userId).HasClaimedFreeReward;

            return result;
        }

        public async Task<OpenedPackViewModel> OpenFreePackAsync(Guid userId)
        {
            Random rnd = new Random();
            List<Players> players = new List<Players>();
            int number;
            OpenedPackViewModel playerModel = new OpenedPackViewModel();
            TeamViewModel teamViewModel = new TeamViewModel();
            playerModel.Id = 0;
            playerModel.Name = "Free Pack";

            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().Where(x => x.Position == "top").ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().Where(x => x.Position == "jng").ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().Where(x => x.Position == "mid").ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().Where(x => x.Position == "adc").ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().Where(x => x.Position == "sup").ToList()[number]);

            foreach (var item in players)
            {
                playerModel.Players.Add(new PlayerViewModel { 
                    Name = item.Name,
                    Nickname = item.Nickname,
                    Nationality = item.Nationality,
                    Age = item.Age,
                    Position = item.Position,
                    Image = item.Image
                });
                await _context.UserPlayers.AddAsync(new UserPlayers {UserId=userId,PlayerId = item.Id});
            }
            UserPacks up = await _context.UserPacks.FirstAsync(x => x.PackId == 0 && x.UserId == userId);

            _context.UserPacks.Remove(up);
            await _context.SaveChangesAsync();

            return playerModel;
        }

        public async Task<OpenedPackViewModel> OpenNormalPackAsync(Guid userId)
        {
            Random rnd = new Random();
            List<Players> players = new List<Players>();
            int number;
            OpenedPackViewModel playerModel = new OpenedPackViewModel();
            TeamViewModel teamViewModel = new TeamViewModel();
            playerModel.Id = 1;
            playerModel.Name = "Normal Pack";

            number = rnd.Next(0, 50);
            players.Add(_context.Players.AsNoTracking().ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().ToList()[number]);
            number = rnd.Next(0, 10);
            players.Add(_context.Players.AsNoTracking().ToList()[number]);

            foreach (var item in players)
            {
                playerModel.Players.Add(new PlayerViewModel
                {
                    Name = item.Name,
                    Nickname=item.Nickname,
                    Nationality = item.Nationality,
                    Age = item.Age,
                    Position = item.Position,
                    Image = item.Image
                });
                await _context.UserPlayers.AddAsync(new UserPlayers { UserId = userId, PlayerId = item.Id });
            }
            UserPacks up = await _context.UserPacks.FirstAsync(x => x.PackId == 1 && x.UserId == userId);

            _context.UserPacks.Remove(up);
            await _context.SaveChangesAsync();

            return playerModel;
        }
    }
}
