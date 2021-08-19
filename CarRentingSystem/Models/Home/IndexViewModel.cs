using System.Collections.Generic;
using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Models.Home
{
    public class IndexViewModel
    {
        public int TotalCars { get; init; }

        public int TotalUsers { get; init; }

        public int TotalRents { get; init; }

        public IList<LatestCarServiceModel> Cars { get; init; }
    }
}
