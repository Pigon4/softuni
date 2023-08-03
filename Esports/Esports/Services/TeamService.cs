using Esports.Data;
using Esports.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using ViewModels;
using Esports.Data.Models;

namespace Esports.Services
{
    public class TeamService : ITeamService
    {
        private EsportsDbContext _context;

        public TeamService(EsportsDbContext context)
        {
                _context = context;
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
                    Image = player.Image,
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


    }
}
