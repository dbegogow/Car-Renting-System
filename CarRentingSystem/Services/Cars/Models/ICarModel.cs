namespace CarRentingSystem.Services.Cars.Models
{
    public interface ICarModel
    {
        string Brand { get; init; }

        string Model { get; init; }

        int Year { get; init; }
    }
}
