using AutoMapper;
using RESProject.Models;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;

using System.Linq;

namespace RESProject.Mappers.Mapping
{
    internal class DetailsMapper : Profile
    {
        public DetailsMapper()
        {
            CreateMap<RealES, DetailsVM>()
                .ForMember(dest => dest.ImageName, opt => opt.MapFrom(src => src.Images.Select(x => x.ImageName).ToList()))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Address.Country.Name))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City.Name))
                .ForMember(dest => dest.Hood, opt => opt.MapFrom(src => src.Address.Hood.Name))
                .ForMember(dest => dest.N_BedRoom, opt => opt.MapFrom(src => src.Room.N_Bedroom))
                .ForMember(dest => dest.TotalRooms, opt => opt.MapFrom(src => src.Room.N_Rooms))
                .ForMember(dest => dest.N_Bathrooms, opt => opt.MapFrom(src => src.Room.N_Bathroom))
                .ForMember(dest => dest.Area_Siza, opt => opt.MapFrom(src => src.Area_Size))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.CreatedAt.Year.ToString()))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.Garage, opt => opt.MapFrom(src => src.Room.N_Garage))
                .ForMember(dest => dest.UserPP, opt => opt.MapFrom(src => src.User.ImageName))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.User.PhoneNumber))
                .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.RealESFeatures.Select(x => x.Feature.Name).ToList()))
                .ForMember(dest => dest.userID, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["UserId"].ToString()))
                .ForMember(dest => dest.RealID, opt => opt.MapFrom(src => src.ID))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comments.Select(x => new Comments
                {
                    CreatedAT = x.CreatedAT,
                    Description = x.Description,
                    User = x.User,
                    UserID = x.UserID,
                    RealESID = x.RealESID
                }).OrderByDescending(x => x.CreatedAT).ToList()))
                .ForMember(dest => dest.Views, opt => opt.MapFrom(src => src.Views));
        }
    }
}
