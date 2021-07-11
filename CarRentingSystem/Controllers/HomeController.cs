﻿using CarRentingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
