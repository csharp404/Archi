using System.Web.Mvc;

namespace RESProject.Models.ViewModels.RealESVM
{
    public sealed record class HomeVM
    {
        public List<CardVM>? Cards { set; get; } 
        public List<CountCategoty>? CountsCategory { set; get; }
        public string? Word { set; get; }
        public string? CategoryId { set; get; }    
        public string? PlaceCountry { set; get; }    
        public string? Price { set; get; }
        public List<SelectionFeatures> Categories { get; set; }
    }
}
