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

        public LeaderboardsService(EsportsDbContext context)
        {
              _context = context;
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
            InspectUserViewModel ins = await _context.Users
                .Where(x => x.Id == userId)
                .Select(x => new InspectUserViewModel
                {
                    Username = x.UserName,
                    Points = x.Points

                }).FirstAsync();
                
                
                
                
            throw new NotImplementedException();
        }
    }
}
