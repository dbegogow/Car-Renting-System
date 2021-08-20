using Microsoft.AspNetCore.Mvc;
using CarRentingSystem.Services.Cars;

namespace CarRentingSystem.Areas.Admin.Controllers
{
    public class CarsController : AdminController
    {
        private readonly ICarService _cars;

        public CarsController(ICarService cars)
            => _cars = cars;

        public IActionResult All()
        {
            var cars = this._cars
                .All(publicOnly: false)
                .Cars;

            return View(cars);
        }

        public IActionResult ChangeVisibility(int id)
        {
            this._cars.ChangeVisibility(id);

            return RedirectToAction(nameof(All));
        }
    }
}
