using Esports.Data;
using Esports.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using ViewModels;
using Esports.Data.Models;
using Esports.Data.Helpers.Contracts;

namespace Esports.Services
{
    public class TeamService : ITeamService
    {
        private EsportsDbContext _context;
        private IImageConverter _imageConverter;
        public TeamService(EsportsDbContext context, IImageConverter imageConverter)
        {
                _context = context;
            _imageConverter = imageConverter;
        }
        public async Task<List<AddPlayerViewModel>> GetAllPlayersOfUserAsync(Guid userId)
        {
            List<AddPlayerViewModel> players = new List<AddPlayerViewModel>();
            Guid[] ids = await _context.UserPlayers
                .AsNoTracking()
                .Where(x=>x.UserId==userId)
                .Select(x => x.PlayerId)
                .Distinct().ToArrayAsync();
            foreach (Guid id in ids)
            {
                Players player = await _context.Players.FirstAsync(x => x.Id == id);
                players.Add(new AddPlayerViewModel
                {
                    Id = player.Id,
                    Age = player.Age,
                    Image = _imageConverter.ConvertToImage(player.Image),
                    Name = player.Name,
                    Nationality = player.Nationality,
                    Nickname = player.Nickname,
                    Position = player.Position,
                    TeamId = player.TeamId
                });
            }

            return players;
        }

        public async Task AddPlayerToTeamAsync(string name, Guid userId)
        {
            Players player = await  _context.Players.FirstAsync(x => x.Nickname == name);
            switch (player.Position)
            {
                case "top": await _context.UserTeams.AddAsync(new UserTeams { UserId = userId, TopId = player.Id }); break;
                case "jng": await _context.UserTeams.AddAsync(new UserTeams { UserId = userId, JngId = player.Id }); break;
                case "mid": await _context.UserTeams.AddAsync(new UserTeams { UserId = userId, MidId = player.Id }); break;
                case "adc": await _context.UserTeams.AddAsync(new UserTeams { UserId = userId, AdcId = player.Id }); break;
                case "sup": await _context.UserTeams.AddAsync(new UserTeams { UserId = userId, SupId = player.Id }); break;
            }
            
            await _context.SaveChangesAsync();
        }

        public async Task<List<AddPlayerViewModel>> GetAllPlayersByPositionOfUserAsync(Guid userId, string position)
        {
            List<AddPlayerViewModel> players = new List<AddPlayerViewModel>();
            Guid[] ids = await _context.UserPlayers
                .AsNoTracking()
                .Where(x => x.UserId == userId && x.Player.Position == position)
                .Select(x => x.PlayerId)
                .Distinct().ToArrayAsync();
            foreach (Guid id in ids)
            {
                Players player = await _context.Players.FirstAsync(x => x.Id == id);
                players.Add(new AddPlayerViewModel
                {
                    Id = player.Id,
                    Age = player.Age,
                    Image = _imageConverter.ConvertToImage(player.Image),
                    Name = player.Name,
                    Nationality = player.Nationality,
                    Nickname = player.Nickname,
                    Position = player.Position,
                    TeamId = player.TeamId
                });
            }

            return players;
        }

        public async Task<List<PlayerViewModel>> GetUserTeamPlayersAsync(List<Guid> ids)
        {
            List<PlayerViewModel> players = new List<PlayerViewModel>();
            foreach (var item in ids)
            {
                if (item != Guid.Parse("00000000-0000-0000-0000-000000000000"))
                {
                    var player = await _context.Players.FirstOrDefaultAsync(x => x.Id == item);
                    players.Add(new PlayerViewModel
                    {
                        Image = player.Image,
                        Nickname = player.Nickname,
                        Position = player.Position
                    });
                }

            }

            return players;
        }

        public async Task<MyTeamViewModel> GetUserTeamAsync(Guid userId)
        {
            MyTeamViewModel team = new MyTeamViewModel();
            List<Guid> ids = new List<Guid>();
            ids.Add(await _context.UserTeams.Where(x => x.UserId == userId)
                .Select(x => x.TopId).FirstOrDefaultAsync());
            ids.Add(await _context.UserTeams.Where(x => x.UserId == userId)
                .Select(x => x.JngId).FirstOrDefaultAsync());
            ids.Add(await _context.UserTeams.Where(x => x.UserId == userId)
                .Select(x => x.MidId).FirstOrDefaultAsync());
            ids.Add(await _context.UserTeams.Where(x => x.UserId == userId)
                .Select(x => x.AdcId).FirstOrDefaultAsync());
            ids.Add(await _context.UserTeams.Where(x => x.UserId == userId)
                .Select(x => x.SupId).FirstOrDefaultAsync());
            if (ids.Any(x => x != Guid.Parse("00000000-0000-0000-0000-000000000000")))
            {
                List<PlayerViewModel> players = await GetUserTeamPlayersAsync(ids);

                team.Top = players.FirstOrDefault(x => x.Position == "top");
                team.Jng = players.FirstOrDefault(x => x.Position == "jng");
                team.Mid = players.FirstOrDefault(x => x.Position == "mid");
                team.Adc = players.FirstOrDefault(x => x.Position == "adc");
                team.Sup = players.FirstOrDefault(x => x.Position == "sup");
            }


           return team;
        }
    }
}
