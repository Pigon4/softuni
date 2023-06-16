﻿using Microsoft.AspNetCore.Mvc;
using playerdle.Models;
using System.Diagnostics;

namespace playerdle.Controllers
{
    public class PremierController : Controller
    {

        public IActionResult Index()
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
