using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESProject.Models.Models;
using Microsoft.AspNetCore.Mvc;
namespace RESProject.Repositories.Entities.AddressRepo
{
    public interface IRepositoryAddress
    {
        public List<Country> GetCountries();
        public List<City> GetCities(string id);
        public List<Hood> GetHoods(string id);
        public int Create(Address cr,string RealESID);
        
        public Task<int> Update(CreateVM prop,string realid);
    }
}
