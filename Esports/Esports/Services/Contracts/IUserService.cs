namespace Esports.Services.Contracts
{
    public interface IUserService
    {
        public Task<int> GetUserPointsAsync(Guid userId);
    }
}
