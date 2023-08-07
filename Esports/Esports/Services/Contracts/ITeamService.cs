namespace Esports.Services.Contracts
{
    using ViewModels;
    public interface ITeamService
    {
        public Task<List<AddPlayerViewModel>> GetAllPlayersOfUserAsync(Guid userId);
        public Task<List<AddPlayerViewModel>> GetAllPlayersByPositionOfUserAsync(Guid userId, string position);
        public Task AddPlayerToTeamAsync(AddPlayerViewModel vm);
    }
}
