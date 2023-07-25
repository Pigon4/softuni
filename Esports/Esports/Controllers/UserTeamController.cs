using Esports.Data;
using Esports.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
namespace Esports.Controllers
{
    public class UserTeamController : Controller
    {
        private EsportsDbContext _context;

        public UserTeamController(EsportsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
