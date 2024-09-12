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
    internal class FeatureMapper : Profile
    {
        public FeatureMapper()
        {
            CreateMap<CreateVM, RealESFeature>()
                .ForMember(dest => dest.FeatureID, opt => opt.MapFrom(src => src.Features.Where(x => x.isSelected).Select(x => x.Id)))
            .ForMember(dest => dest.RealESID, opt => opt.MapFrom(src => src.IDRealES)); 
        }
    }
}
