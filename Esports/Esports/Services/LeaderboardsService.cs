using Esports.Data;
using Esports.Services.Contracts;

namespace Esports.Services
{
    public class LeaderboardsService : ILeadearboardsService
    {
        private EsportsDbContext _context;

        public LeaderboardsService(EsportsDbContext context)
        {
              _context = context;
        }

        public async Task GetTopTenAsync()
        {
            throw new NotImplementedException();
        }
    }
}
