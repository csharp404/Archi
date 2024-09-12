using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RESProject.DataAccess.Data;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using RESProject.Repositories.Entities.AddressRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESProject.Models.Models;
namespace RESProject.Repositories.Entities
{
    public  class RepositoryRealES : IRepositoryRealES
    {
        private readonly MyDbContext db;
        private readonly IMapper mapper;
        private readonly IRepositoryAddress repositoryAddress;
        private readonly IRepositoryRoom repositoryRoom;
        private readonly IRepositoryRealESImages IRepositoryRealESImages;
        private readonly IRepositoryRealESFeature IRepositoryRealESFeature;

        public RepositoryRealES(MyDbContext db, IMapper mapper,
            IRepositoryAddress v, IRepositoryRoom repositoryRoom,
            IRepositoryRealESImages IRepositoryRealESImages, IRepositoryRealESFeature repositoryRealESFeature)
        {
            this.db = db;
            this.mapper = mapper;
            this.repositoryAddress = v;
            this.repositoryRoom = repositoryRoom;
            this.IRepositoryRealESImages = IRepositoryRealESImages;
            this.IRepositoryRealESFeature = repositoryRealESFeature;
        }

        public int Create(CreateVM v, string UserId)
        {
            try
            {
                var RealESid = Guid.NewGuid().ToString();
                RealES Reales = mapper.Map<RealES>(v);
                Reales.ID = RealESid;
                Reales.UserID = UserId;
                Reales.RealESFeatures = IRepositoryRealESFeature.CreateFeature(v, RealESid);
                db.RealES.AddAsync(Reales);
                db.SaveChanges();

                Address address = mapper.Map<Address>(v);
                _ = repositoryAddress.Create(address, RealESid);


                Room room = mapper.Map<Room>(v);
                _ = repositoryRoom.Create(room, RealESid);


                var Images = IRepositoryRealESImages.CreateImages(v, RealESid);
                return 1;

            }
            catch (Exception ex) {

                throw;
            }




        }

       
       

        public int Delete(string id)
        {
            try
            {

            var reales = db.RealES.Include(x => x.Comments).Include(x => x.Address).Include(x => x.Favorites).Include(x => x.RealESFeatures).Include(x => x.Images).FirstOrDefault(x => x.ID == id);
            var address = db.Addresses.Where(x => x.RealESID == id).FirstOrDefault();
            var room = db.Rooms.Where(x => x.RealESId == id).FirstOrDefault();
            db.RealES.Remove(reales);
            db.Addresses.Remove(address);
            db.Rooms.Remove(room);
            db.SaveChanges();
            return 1;
            }
            catch (Exception ex)
            {

                
                throw;
            }

        }

        public async Task<RealES> GetById(string id)
        {
            RealES realES = await db.RealES
   .Include(x => x.Address)
   .ThenInclude(x => x.Country)
   .ThenInclude(x => x.Cities)
   .ThenInclude(x => x.hoods)
   .Include(x => x.Images)
   .Include(x => x.Room)
   .Include(x => x.User)
   .Include(x => x.RealESFeatures)
   .ThenInclude(x => x.Feature)
   .Include(x => x.Category)
   .FirstOrDefaultAsync(x => x.ID == id);
            if (realES != null)
            {
                return realES;
            }
            else { 
            return new RealES();
            
            }
        }

        public async Task<List<RealES>> listRealEs()
        {
            var data = db.RealES
           .Include(x => x.Address)
           .ThenInclude(x => x.Country)
           .ThenInclude(x => x.Cities)
           .ThenInclude(x => x.hoods)
           .Include(x => x.Images)
           .Include(x => x.Room)
           .Include(x => x.User)?
           .Include(x => x.RealESFeatures)
           .ThenInclude(x => x.Feature)
           .Include(x => x.Category).ToList();

            return data;
        }

        public async Task<int> Update(CreateVM prop)
        {
            var realES =await GetById(prop.IDRealES);
            
            realES.Name = prop.Name.Trim();
            realES.Price = prop.Price;
            realES.Description = prop.Description;
            realES.AddressID = prop.IDAddress;
            realES.RoomID = prop.IDRoom;
            realES.Area_Size = prop.Area_Size;
            realES.Email = prop.Email;
            realES.PhoneNumber = prop.PhoneNumber;
            realES.CategoryID = prop.CategoryId;

         repositoryAddress.Update(prop, prop.IDRealES);
           

           repositoryRoom.Update(prop, prop.IDRealES);
            

            IRepositoryRealESFeature.UpdateFeature(prop, prop.IDRealES);

            IRepositoryRealESImages.CreateImages(prop, prop.IDRealES);
           

            db.RealES.Update(realES);
            db.SaveChanges();



            throw new NotImplementedException();
        }
    }
}
