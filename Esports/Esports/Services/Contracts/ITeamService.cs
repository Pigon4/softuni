namespace Esports.Services.Contracts
{
    using ViewModels;
    public interface ITeamService
    {
        public Task<List<AddPlayerViewModel>> GetAllPlayersOfUserAsync(Guid userId);
        public Task AddPlayerToTeamAsync(AddPlayerViewModel vm);
    }
}
