using Esports.Data;
using Esports.Data.Models;
using Esports.Services;
using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Esports.Controllers
{
    public class PacksController : Controller
    {
        private IPackService _packsService;

        public PacksController(IPackService packsService)
        {
            this._packsService = packsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetFreePack()
        {
            var currUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                
            await _packsService.GetFreePackAsync(Guid.Parse(currUserId));

            return RedirectToAction("Packs", "Home");
        }
    }
}
