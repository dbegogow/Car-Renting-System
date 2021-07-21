﻿using System.Collections.Generic;

namespace CarRentingSystem.Services.Cars
{
    public class CarQueryServiceModel
    {
        public int CurrentPage { get; init; }

        public int CarsPerPage { get; init; }

        public int TotalCars { get; init; }

        public IEnumerable<CarServiceModel> Cars { get; init; }
    }
}
