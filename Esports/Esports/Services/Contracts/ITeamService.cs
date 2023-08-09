namespace Esports.Services.Contracts
{
    using ViewModels;
    public interface ITeamService
    {
        public Task<List<AddPlayerViewModel>> GetAllPlayersOfUserAsync(Guid userId);
        public Task<List<AddPlayerViewModel>> GetAllPlayersByPositionOfUserAsync(Guid userId, string position);
        public Task AddPlayerToTeamAsync(string name, Guid userId);
        public Task<List<PlayerViewModel>> GetUserTeamPlayersAsync(List<Guid> ids);
        public Task<MyTeamViewModel> GetUserTeamAsync(Guid userId);
    }
}
