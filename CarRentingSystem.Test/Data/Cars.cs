using System.Linq;
using System.Collections.Generic;
using CarRentingSystem.Data.Models;

namespace CarRentingSystem.Test.Data
{
    public static class Cars
    {
        public static IEnumerable<Car> TenPublicCars()
            => Enumerable.Range(0, 10).Select(i => new Car
            {
                IsPublic = true
            });
    }
}
