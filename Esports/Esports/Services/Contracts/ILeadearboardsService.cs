using ViewModels;
namespace Esports.Services.Contracts
{
    public interface ILeadearboardsService
    {
        public Task<List<UserViewModel>> GetTopTenAsync();
        public Task<InspectUserViewModel> GetUserToInspectAsync(Guid userId);
    }
}
