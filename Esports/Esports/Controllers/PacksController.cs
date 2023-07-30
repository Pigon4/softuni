using Esports.Data;
using Esports.Data.Models;
using Esports.Services;
using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ViewModels;

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

        public IActionResult RewardsFromPack(int packId)
        {


            return View();
        }

        public async Task<IActionResult> GetFreePack()
        {
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                
            await _packsService.GetFreePackAsync(currUserId);

            return RedirectToAction("Packs", "Home");
        }

        public async Task<IActionResult> OpenFreePack()
        {
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            OpenedPackViewModel model = new OpenedPackViewModel();

            model = await _packsService.OpenFreePackAsync(currUserId);


            return RedirectToAction("RewardsFromPack", "Packs", model );
        }


        public async Task<IActionResult> OpenNormalPack()
        {
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            OpenedPackViewModel model = new OpenedPackViewModel();

            model = await _packsService.OpenNormalPackAsync(currUserId);

            return RedirectToAction("RewardsFromPack", "Packs", model);
        }
    }
}
