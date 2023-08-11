using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Esports.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService _administratorService;

        public AdministratorController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ControlPanel()
        {
            if (ModelState.IsValid && User.IsInRole("Admin"))
            {

                return View();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
