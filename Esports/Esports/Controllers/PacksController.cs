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

        [HttpGet]
        public async Task<IActionResult> RewardsFromPack(int packId)
        {
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            OpenedPackViewModel model = new OpenedPackViewModel();

            if (packId == 0)
            {
                model = await _packsService.OpenFreePackAsync(currUserId);
            }
            else if (packId == 1)
            {
                model = await _packsService.OpenNormalPackAsync(currUserId);
            }
            
            return View(model);
        }

        public async Task<IActionResult> GetFreePack()
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

                    await _packsService.GetFreePackAsync(currUserId);

                    return RedirectToAction("Packs", "Home");
                }
                else
                {
                    return Redirect("/Identity/Account/Login");
                }
               

            }

            else { return RedirectToAction("Index", "Home"); }

        }

    }
}
