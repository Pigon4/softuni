using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace Esports.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService _administratorService;
        private readonly ITeamService _teamService;

        public AdministratorController(IAdministratorService administratorService, ITeamService teamService)
        {
            _administratorService = administratorService;
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ControlPanel()
        {
            if (ModelState.IsValid && User.IsInRole("Admin"))
            {
                TeamViewModel[] model = await _teamService.GetAllTeamsAsync();
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task GivePoints(string[] winners)
        {
            await _administratorService.GivePoints(winners);

        }

    }
}
