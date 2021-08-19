using AutoMapper;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Models.Cars;
using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Car, LatestCarServiceModel>();
            this.CreateMap<CarDetailsServiceModel, CarFormModel>();

            this.CreateMap<Car, CarDetailsServiceModel>()
                .ForMember(c => c.UserId, cfg => cfg.MapFrom(c => c.Dealer.UserId));
        }
    }
}
