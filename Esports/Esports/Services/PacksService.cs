using Esports.Data;
using Esports.Data.Models;
using Esports.Services.Contracts;

namespace Esports.Services
{
    public class PacksService : IPackService
    {
        private EsportsDbContext _context;

        public PacksService(EsportsDbContext context)
        {
            _context = context;
        }

        public async Task GetFreePackAsync(Guid userId)
        {
            UserPacks up = new UserPacks { UserId = userId, PackId = 0 };

            _context.UserPacks.Add(up);
            _context.SaveChanges();

        }
    }
}
