using AutoMapper;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.UserVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Mappers.Mapping
{
    internal class MyProfileMapper : Profile
    {
        public MyProfileMapper()
        {
            CreateMap<User, MyProfileVM>()
           .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
           .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
           .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.UserName))
           .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
           .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
           .ForMember(dest => dest.BDay, opt => opt.MapFrom(src => src.BDay))
           .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
           .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
           .ForMember(dest => dest.Bio, opt => opt.MapFrom(src => src.Bio))
           .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.ImageName))
           .ForMember(dest => dest.CoverName, opt => opt.MapFrom(src => src.CoverName));
        }
    }
}
