using Microsoft.AspNetCore.Hosting;
using RESProject.DataAccess.Data;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Repositories.Entities
{
    public class RepositoryRealESImages : IRepositoryRealESImages
    {
       
        private MyDbContext db;

        public RepositoryRealESImages(MyDbContext b)
        {
           this.db = b;
        }
        public List<RealESImages> CreateImages(CreateVM v,string RealESid)
        {

            List<RealESImages> images = new List<RealESImages>();
            foreach (var item in v.ImageFiles)
            {
                var guid = Guid.NewGuid().ToString();

                var path = Path.Combine( "Images/RealESImages", guid + item.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    item.CopyTo(stream);
                };
                images.Add(
                   new RealESImages
                   {
                       ID = Guid.NewGuid().ToString(),
                       ImageName = guid + item.FileName,
                       ImagePath = path,
                       RealESId = RealESid
                   }
                );
            }
            db.RealESImages.AddRangeAsync(images);
            return images;
        }

      
    }
}
