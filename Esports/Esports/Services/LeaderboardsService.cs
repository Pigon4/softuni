using Esports.Data;
using Esports.DataModels;
using Esports.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using ViewModels;

namespace Esports.Services
{
    public class LeaderboardsService : ILeadearboardsService
    {
        private readonly EsportsDbContext _context;
        private readonly ITeamService _teamService;

        public LeaderboardsService(EsportsDbContext context, ITeamService teamService)
        {
              _context = context;
            _teamService = teamService;
        }

        public async Task<List<UserViewModel>> GetTopTenAsync()
        {
            List<UserViewModel> players = new List<UserViewModel>();

            foreach (var user in await _context.Users.OrderByDescending(x => x.Points).Take(10).ToArrayAsync()) 
            {
                players.Add(new UserViewModel
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Points = user.Points
                });
            }

            return players;
        }

        public async Task<InspectUserViewModel> GetUserToInspectAsync(Guid userId)
        {
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
            List<PlayerViewModel> players = await _teamService.GetUserTeamPlayersAsync(ids);

            InspectUserViewModel ins = await _context.Users
                .Where(x => x.Id == userId)
                .Select(x => new InspectUserViewModel
                {
                    Username = x.UserName,
                    Points = x.Points,
                    Team = players

                }).FirstAsync();

            return ins;
        }
    }
}
