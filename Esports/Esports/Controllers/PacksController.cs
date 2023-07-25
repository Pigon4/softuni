using Esports.Data;
using Esports.Data.Models;
using Esports.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Esports.Controllers
{
    public class PacksController : Controller
    {
        private PacksService packsService;

        public PacksController(PacksService packsService)
        {
            this.packsService = packsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetFreePack()
        {
            var currUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                
            await packsService.GetFreePackAsync(Guid.Parse(currUserId));

            return RedirectToAction("Packs", "Home");
        }
    }
}
