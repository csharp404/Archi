using AutoMapper;
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

namespace RESProject.Repositories.Entities
{
    public class RepositoryRoom : IRepositoryRoom
    {
        private MyDbContext db;
        private IMapper mapper;

        public RepositoryRoom(MyDbContext db,IMapper mapper)
        {
            this.db = db;
            this.mapper=mapper;
          
        }
        public int Create(Room room, string RealESid)
        {
            room.RealESId= RealESid;    
            room.RoomID = Guid.NewGuid().ToString();
           db.Rooms.Add(room);  
            db.SaveChanges();
            
            return 1;
        }

      

        public int Update(CreateVM Upadte, string realid)
        {
            try
            {

            var data = mapper.Map<Room>(Upadte);
            var real  = db.RealES.Include(x=>x.Images).Where(x=>x.ID==realid).FirstOrDefault();
            real.Room = data;
            db.SaveChanges();
            return 1;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
