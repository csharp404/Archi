using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.UserVms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RESProject.Mappers.Mapping
{
    internal class RegisterMapper : Profile
    {
        


        public RegisterMapper()
        {
            
            CreateMap<RegisterVM,User > ()
                .ForMember(x=>x.UserName,x=>x.MapFrom(x=>x.Email))
                .ForMember(x=>x.FirstName,x=>x.MapFrom(x=>x.FirstName))
                .ForMember (x=>x.LastName,x=>x.MapFrom(x=>x.LastName))
                .ForMember(x=>x.PhoneNumber,x=>x.MapFrom(x=>x.PhoneNumber))
                .ForMember(x=>x.ImageName,x=>x.MapFrom(x=> "Default.png"))
                .ForMember(x=>x.ImagePath,x=>x.MapFrom(x=>  "/Images/Default.png"))  
                .ReverseMap();



             
        }
    }
}
