using AutoMapper;
using System.Linq;
using CarRentingSystem.Data;
using Microsoft.AspNetCore.Mvc;
using CarRentingSystem.Models.Home;
using AutoMapper.QueryableExtensions;
using CarRentingSystem.Services.Statistics;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStatisticsService statistics;
        private readonly IConfigurationProvider mapper;
        private readonly CarRentingDbContext data;

        public HomeController(
            IStatisticsService statistics,
            IMapper mapper,
            CarRentingDbContext data)
        {
            this.statistics = statistics;
            this.mapper = mapper.ConfigurationProvider;
            this.data = data;
        }

        public IActionResult Index()
        {
            var totalCars = this.data.Cars.Count();
            var totalUsers = this.data.Users.Count();

            var cars = this.data
                .Cars
                .OrderByDescending(c => c.Id)
                .ProjectTo<CarIndexViewModel>(this.mapper)
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

        public IActionResult Error()
            => View();
    }
}
