using AutoMapper;
using Microsoft.AspNetCore.Identity;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace RESProject.Mappers.Mapping
{
    internal class CreateMapper:Profile
    {
       
        public CreateMapper()
        {

            CreateMap<CreateVM, RealES>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim()))
                 .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                 .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                 .ForMember(dest => dest.Area_Size, opt => opt.MapFrom(src => src.Area_Size))
                 .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                 .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                 .ForMember(dest => dest.CategoryID, opt => opt.MapFrom(src => src.CategoryId)).ReverseMap();
                





            
                   
        }
    }
}
