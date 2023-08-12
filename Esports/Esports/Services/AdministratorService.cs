using Esports.Data;
using Esports.Data.Models;
using Esports.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Esports.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly EsportsDbContext _context;
        public AdministratorService(EsportsDbContext context)
        {
            _context = context;
        }

        public async Task GivePoints(string[] winners)
        {
            foreach (var winner in winners)
            {
                Guid teamId = _context.Teams.First(x => x.Name == winner).Id;
                Guid[] playerIds = await _context.Players.Where(x => x.TeamId == teamId)
                    .Select(x => x.Id)
                    .ToArrayAsync();
                Guid[] userIds = await _context.UserPlayers
                    .Select(x => x.UserId)
                    .Distinct().ToArrayAsync();

                foreach (var item in userIds)
                {
                    int count = _context.UserPlayers
                        .Where(x => x.UserId == item && playerIds.Contains(x.PlayerId))
                        .ToArray().Count();
                    var user = await _context.Users
                        .FirstAsync(x => x.Id == item);
                    user.Points += count;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }

            }


        }
    }
}
