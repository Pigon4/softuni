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


        [HttpPost]
        public async Task<JsonResult> UserPlayers(string position)
        {
            List<AddPlayerViewModel> players = new List<AddPlayerViewModel>();
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            players = await _teamService.GetAllPlayersByPositionOfUserAsync(currUserId, position);


            return new JsonResult(players);
        }

        [HttpGet]
        public async Task<string> AddPlayer(string plName)
        {
            Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            await _teamService.AddPlayerToTeamAsync(plName, currUserId);

            return "success";
        }

    }
}
