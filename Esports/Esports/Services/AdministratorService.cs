using Esports.Data;
using Esports.Data.Models;
using Esports.Services.Contracts;

namespace Esports.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly EsportsDbContext _context;
        public AdministratorService(EsportsDbContext context)
        {
            _context = context;
        }
        public async Task doSmth()
        {

        }
    }
}
