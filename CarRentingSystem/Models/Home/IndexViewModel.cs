using System.Collections.Generic;

namespace CarRentingSystem.Models.Home
{
    public class IndexViewModel
    {
        public int TotalCars { get; init; }

        public int TotalUsers { get; init; }

        public int TotalRents { get; init; }

        public List<CarIndexViewModel> Cars { get; init; }
    }
}
