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
    internal class ManagaProfileMapper:Profile
    {

        public ManagaProfileMapper()
        {
            CreateMap<User, ManageProfileVM>()
                .ForMember(x => x.FirstName, x => x.MapFrom(x => x.FirstName))
                .ForMember(x => x.LastName, x => x.MapFrom(x => x.LastName))
                .ForMember(x => x.Email, x => x.MapFrom(x => x.Email))
                .ForMember(x => x.Country, x => x.MapFrom(x => x.Country))
                .ForMember(x => x.City, x => x.MapFrom(x => x.City))
                .ForMember(x => x.PhoneNumber, x => x.MapFrom(x => x.PhoneNumber))
                .ForMember(x => x.Bio, x => x.MapFrom(x => x.Bio)).ReverseMap();
        }


     
    }
}
