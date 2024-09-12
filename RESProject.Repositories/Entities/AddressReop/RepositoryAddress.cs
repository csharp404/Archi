using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESProject.DataAccess.Data;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Repositories.Entities.AddressRepo
{
    public class RepositoryAddress : IRepositoryAddress
    {
        private MyDbContext _db;
        private IMapper mapper;
        public RepositoryAddress(MyDbContext d,IMapper mp)
        {
            _db = d;
            mapper = mp;
        }

        public int Create(Address cr, string RealESID)
        {
            cr.RealESID = RealESID;
            cr.AddressID = Guid.NewGuid().ToString();
            _db.Addresses.Add(cr);
            _db.SaveChanges();
          
            return 1;
        }

        public List<City> GetCities(string id)
        {
            var data = _db.Cities.Where(x => x.CountryId == id).ToList();
            return data;
        }

        public List<Country> GetCountries()
        {
            var data = _db.Countries.ToList();
            return data;
        }

        public List<Hood> GetHoods(string id)
        {
            var data = _db.Hoods.Where(x => x.CityId == id).ToList();
            return data;
        }

       

        public async Task<int> Update(CreateVM prop, string realid)
        {
            try
            {

            var data = mapper.Map<Address>(prop);
            var real = await _db.RealES.Include(x=>x.Address).Where(x => x.ID == realid).FirstOrDefaultAsync();
            real.Address = data;
            _db.SaveChanges();
            return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
