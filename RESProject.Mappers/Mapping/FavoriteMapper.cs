using AutoMapper;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Mappers.Mapping
{
    internal class FavoriteMapper:Profile
    {
        public FavoriteMapper()
        {
            
        CreateMap<RealES, FavVM>()
            .ForMember(dest => dest.RealId, opt => opt.MapFrom(src => src.ID))
            .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.Images.FirstOrDefault().ImageName))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Address.Country.Name))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City.Name))
            .ForMember(dest => dest.Hood, opt => opt.MapFrom(src => src.Address.Hood.Name));
        }
    }
}
