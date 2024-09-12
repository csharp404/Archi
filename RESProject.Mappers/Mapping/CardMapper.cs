using AutoMapper;
using RESProject.Models.ViewModels.RealESVM;
using RESProject.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Features;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace RESProject.Mappers.Mapping
{
    internal class CardMapper:Profile
    {
        public CardMapper()
        {
            CreateMap<RealES, CardVM>()
             .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.Images.Select(x => x.ImageName).FirstOrDefault()))
             .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
             .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Address.Country.Name))
             .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City.Name))
             .ForMember(dest => dest.Hood, opt => opt.MapFrom(src => src.Address.Hood.Name))
             .ForMember(dest => dest.Area_Siza, opt => opt.MapFrom(src => src.Area_Size))
             .ForMember(dest => dest.UserPP, opt => opt.MapFrom(src => src.User.ImageName))
             .ForMember(dest => dest.TotalRooms, opt => opt.MapFrom(src => src.Room.N_Bathroom))
             .ForMember(dest => dest.N_BedRoom, opt => opt.MapFrom(src => src.Room.N_Bedroom))
             .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
             .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CreatedAt.ToShortDateString()))
             .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID))
             .ForMember(dest => dest.RealId, opt => opt.MapFrom(src => src.ID));
             
        }
    }
}
