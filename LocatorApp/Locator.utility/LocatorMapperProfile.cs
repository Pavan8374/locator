using AutoMapper;
using Locator.Models.Response;
using Locator.Models.ViewModels;

namespace Locator.utility
{
    public class LocatorMapperProfile : Profile
    {

        public LocatorMapperProfile()
        {
            CreateIPGeoLocationMaps();
        }

        private void CreateIPGeoLocationMaps()
        {
            CreateMap<GeoLocationResponse, GeoLocationModel>()
                .ForMember(dest => dest.Ip, opt => opt.MapFrom(src => src.Ip))
                .ForMember(dest => dest.CountryCode2, opt => opt.MapFrom(src => src.CountryCode2))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.CountryName))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude));
        }

    }

}
