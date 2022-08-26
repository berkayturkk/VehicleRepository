using AutoMapper;
using VehicleRepository.API.Dtos;
using VehicleRepository.Entities.Concrete;

namespace VehicleRepository.API.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.CarUser.UserName))
                .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color.ColorName));
            CreateMap<Bus, BusDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.BusUser.UserName))
                .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color.ColorName));
            CreateMap<Boat, BoatDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.BoatUser.UserName))
                .ForMember(dest => dest.ColorName, opt => opt.MapFrom(src => src.Color.ColorName));
        }
    }
}
