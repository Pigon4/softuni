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
        public Task AddPlayerToTeamAsync(AddPlayerViewModel vm)
        {
            throw new NotImplementedException();
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
    }
}
