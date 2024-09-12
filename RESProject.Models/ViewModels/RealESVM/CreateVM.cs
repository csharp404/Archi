using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace RESProject.Models.ViewModels.RealESVM
{
    public class CreateVM
    {
        public string? IDRealES { get; set; }
        public string? IDAddress { get; set; }
       
        public string? IDRoom { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Area_Size { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? UserID { get; set; }
        public string? CountryId { get; set; }
        public string? CityId { get; set; }
        public string? HoodId { get; set; }
        public List<SelectListItem> CountriesListItems { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CitiesListItems { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> HoodsListItems { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CategoryListItems { get; set; } = new List<SelectListItem>();

        public bool flag { get; set; }

        public string CategoryId { get; set; }

        public string N_Bedroom { get; set; }
        public string N_Bathroom { get; set; }
        public string Carage { get; set; }
        public string N_Rooms { get; set; }
        public string N_Floors { get; set; }
        public string N_Kitchen { get; set; }
        public string N_LivingRoom { get; set; }

        public string YearBuilt { get; set; }
        public List<IFormFile> ImageFiles { get; set; }

        public List<SelectionFeatures>? Features { get; set; }
        

    }
}
