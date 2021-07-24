﻿using CarRentingSystem.Models;
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

        CarDetailsServiceModel Details(int carId);

        int Create(
            string brand,
            string model,
            string description,
            string imageUrl,
            int year,
            int categoryId,
            int dealerId);

        bool Edit(
            int carId,
            string brand,
            string model,
            string description,
            string imageUrl,
            int year,
            int categoryId);

        IEnumerable<CarServiceModel> ByUser(string userId);

        bool IsByDealer(int carId, int dealerId);

        IEnumerable<string> AllBrands();

        IEnumerable<CarCategoryServiceModel> AllCategories();

        bool CategoryExists(int categoryId);
    }
}
