using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CarRentingSystem.Models.Home;
using CarRentingSystem.Services.Cars;
using CarRentingSystem.Services.Statistics;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService cars;
        private readonly IStatisticsService statistics;

        public HomeController(
            ICarService cars,
            IStatisticsService statistics)
        {
            this.cars = cars;
            this.statistics = statistics;
        }

        public IActionResult Index()
        {
            var latestCars = this.cars
                .Latest()
                .ToList();

            var totalStatistics = this.statistics.Total();

            return View(new IndexViewModel
            {
                TotalCars = totalStatistics.TotalCars,
                TotalUsers = totalStatistics.TotalUsers,
                Cars = latestCars
            });
        }

        public IActionResult Error()
            => View();
    }
}
