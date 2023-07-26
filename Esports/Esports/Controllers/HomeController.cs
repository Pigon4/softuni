using Esports.Models;
using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using ViewModels;

namespace Esports.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPackService _packService;

        public HomeController(ILogger<HomeController> logger, IPackService packService)
        {
            _logger = logger;
            _packService = packService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyTeam()
        {
            return View();
        }

        public IActionResult Leaderboards()
        {
            return View();
        }
        public async Task<IActionResult> Packs()
        {
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            Dictionary<Guid, List<int>> dict = new Dictionary<Guid, List<int>>();
            dict.Add(currUserId, await _packService.GetAllPacksByUserIdAsync(currUserId));
            UserPacksViewModel model = new UserPacksViewModel {
                UserPacks = dict,
                HasClaimedFreePack = await _packService.HasClaimedFreePackAsync(currUserId)
            };
            return View(model);
        }
        public IActionResult Live()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}