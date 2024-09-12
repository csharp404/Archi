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
    internal class RoomMapper : Profile
    {
        public RoomMapper()
        {
             CreateMap<CreateVM, Room>()
                 .ForMember(dest => dest.N_Bathroom, opt => opt.MapFrom(src => src.N_Bathroom))
                 .ForMember(dest => dest.N_Bedroom, opt => opt.MapFrom(src => src.N_Bedroom))
                 .ForMember(dest => dest.N_Garage, opt => opt.MapFrom(src => src.Carage))
                 .ForMember(dest => dest.N_Floors, opt => opt.MapFrom(src => src.N_Floors))
                 .ForMember(dest => dest.N_Kitchen, opt => opt.MapFrom(src => src.N_Kitchen))
                 .ForMember(dest => dest.N_LivingRoom, opt => opt.MapFrom(src => src.N_LivingRoom))
                 .ForMember(dest => dest.N_Rooms, opt => opt.MapFrom(src => src.N_Rooms))
;




     
        }
    }
}
