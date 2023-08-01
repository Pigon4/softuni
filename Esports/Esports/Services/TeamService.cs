using Esports.Data;
using Esports.Services.Contracts;

namespace Esports.Services
{
    public class TeamService : ITeamService
    {
        private EsportsDbContext _context;

        public TeamService(EsportsDbContext context)
        {
                _context = context;
        }
        public async Task AddPlayerToTeam()
        {
            
        }
    }
}
