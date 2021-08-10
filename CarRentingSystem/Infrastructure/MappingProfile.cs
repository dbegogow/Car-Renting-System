using AutoMapper;
using CarRentingSystem.Models.Home;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Models.Cars;
using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Car, CarIndexViewModel>();
            this.CreateMap<CarDetailsServiceModel, CarFormModel>();

            this.CreateMap<Car, CarDetailsServiceModel>()
                .ForMember(c => c.UserId, cfg => cfg.MapFrom(c => c.Dealer.UserId));
        }
    }
}
