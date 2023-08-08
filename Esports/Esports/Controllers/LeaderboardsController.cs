using Microsoft.AspNetCore.Mvc;

namespace Esports.Controllers
{
    public class LeaderboardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Inspect()
        {
            return View();
        }
    }
}
