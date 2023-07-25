namespace Esports.Services.Contracts
{
    public interface IPackService
    {
        public Task GetFreePackAsync(Guid userId);
    }
}
