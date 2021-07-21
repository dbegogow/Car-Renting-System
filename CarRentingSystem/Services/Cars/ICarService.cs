using CarRentingSystem.Models;
using System.Collections.Generic;

namespace CarRentingSystem.Services.Cars
{
    public interface ICarService
    {
        CarQueryServiceModel All(
            string brand,
            string searchTerm,
            CarSorting sorting,
            int currentPage,
            int carsPerPage);

        IEnumerable<string> AllCarBrands();
    }
}
