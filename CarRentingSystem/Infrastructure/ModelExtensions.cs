using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Infrastructure
{
    public static class ModelExtensions
    {
        public static string GetInformation(this ICarModel car)
            => car.Brand + "-" + car.Model + car.Year;
    }
}
