﻿using Esports.Models;
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
        private readonly ITeamService _teamService;
        private readonly ILeadearboardsService _leaderboardsService;

        public HomeController(ILogger<HomeController> logger, IPackService packService, ITeamService teamService, ILeadearboardsService leaderboardsService)
        {
            _logger = logger;
            _packService = packService;
            _teamService = teamService;
            _leaderboardsService = leaderboardsService;
        }

        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return Error();
            
        }

        public async Task<IActionResult> MyTeam()
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    MyTeamViewModel model = await _teamService.GetUserTeamAsync(currUserId);

                    return View(model);
                }
                return Redirect("/Identity/Account/Login");

            }
            else { 
                return Error(); 
            }

        }

        public async Task<IActionResult> Leaderboards()
        {
            if (ModelState.IsValid)
            {
                List<UserViewModel> topTen = await _leaderboardsService.GetTopTenAsync();

                return View(topTen);
            }
            else
            {
                return Error();
            }

        }
        public async Task<IActionResult> Packs()
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.IsAuthenticated)
                {
                    Guid currUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    Dictionary<Guid, List<int>> dict = new Dictionary<Guid, List<int>>();

                    dict.Add(currUserId, await _packService.GetAllPacksByUserIdAsync(currUserId));

                    UserPacksViewModel model = new UserPacksViewModel
                    {
                        UserPacks = dict
                    };

                    return View(model);
                }
                return Redirect("/Identity/Account/Login");

            }
            else
            {
                return Error();
            }
            
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