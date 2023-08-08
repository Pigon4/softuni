using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ViewModels;

namespace Esports.Controllers
{
    public class LeaderboardsController : Controller
    {
        private readonly ILeadearboardsService _leadearboardsService;
        public LeaderboardsController(ILeadearboardsService leadearboardsService)
        {
            _leadearboardsService = leadearboardsService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Inspect(Guid userId)
        {
            InspectUserViewModel model = await _leadearboardsService.GetUserToInspectAsync(userId);
            return View(model);
        }
    }
}
