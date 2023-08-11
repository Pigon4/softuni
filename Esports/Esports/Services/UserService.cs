using Esports.Data;
using Esports.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Esports.Services
{
    public class UserService : IUserService
    {
        private readonly EsportsDbContext _context;

        public UserService(EsportsDbContext context)
        {
            _context = context;
        }
        public async Task<int> GetUserPointsAsync(Guid userId)
        {
            int[] points = await _context.Users.Where(x => x.Id == userId)
                .Select(x => x.Points).ToArrayAsync();
            return points[0];
        }
    }
}
