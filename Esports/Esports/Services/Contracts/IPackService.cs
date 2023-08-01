using ViewModels;

namespace Esports.Services.Contracts
{
    public interface IPackService
    {
        public Task GetFreePackAsync(Guid userId);
        public Task<OpenedPackViewModel> OpenFreePackAsync(Guid userId);
        public Task GetNormalPackAsync(Guid userId);
        public Task<OpenedPackViewModel> OpenNormalPackAsync(Guid userId);
        public Task<List<int>> GetAllPacksByUserIdAsync(Guid UserId);
        public bool HasClaimedFreePack(Guid userId);
    }
}
