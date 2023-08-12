using Microsoft.Extensions.ObjectPool;

namespace Esports.Services.Contracts
{
    public interface IAdministratorService
    {
        public Task GivePoints(string[] winners);
    }
}
