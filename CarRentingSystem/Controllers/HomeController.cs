using System.Linq;
using System.Diagnostics;
using CarRentingSystem.Data;
using CarRentingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using CarRentingSystem.Models.Home;
using CarRentingSystem.Services.Statistics;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStatisticsService statistics;
        private readonly CarRentingDbContext data;

        public HomeController(
            IStatisticsService statistics,
            CarRentingDbContext data
        )
        {
            this.statistics = statistics;
            this.data = data;
        }

        public IActionResult Index()
        {
            var totalCars = this.data.Cars.Count();
            var totalUsers = this.data.Users.Count();

            var cars = this.data
                .Cars
                .OrderByDescending(c => c.Id)
                .Select(c => new CarIndexViewModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl
                })
                .Take(3)
                .ToList();

            var totalStatistics = this.statistics.Total();

            return View(new IndexViewModel
            {
                TotalCars = totalStatistics.TotalCars,
                TotalUsers = totalStatistics.TotalUsers,
                Cars = cars
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
