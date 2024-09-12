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
    internal class AddressMapper : Profile
    {
        public AddressMapper()
        {
            CreateMap<CreateVM, Address>()
                .ForMember(dest => dest.HoodID, opt => opt.MapFrom(src => src.HoodId))
                .ForMember(dest => dest.CityID, opt => opt.MapFrom(src => src.CityId))
                .ForMember(dest => dest.CountryID, opt => opt.MapFrom(src => src.CountryId));
        }
    }
}
