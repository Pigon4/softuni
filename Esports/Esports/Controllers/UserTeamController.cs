using Esports.Data;
using Esports.Data.Models;
using Esports.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ViewModels;

namespace Esports.Controllers
{
    public class UserTeamController : Controller
    {
        private ITeamService _teamService;

        public UserTeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddPlayer()
        {

            return View();
        }

        [HttpPost]
        public async Task<JsonResult> UserPlayers(string position)
        {
            List<AddPlayerViewModel> players = new List<AddPlayerViewModel>();
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            players = await _teamService.GetAllPlayersByPositionOfUserAsync(currUserId, position);


            return new JsonResult(players);
        }

    }
}
