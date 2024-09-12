using Microsoft.EntityFrameworkCore;
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
    public class RepositoryRealESFeature : IRepositoryRealESFeature
    {
        private MyDbContext db;

        public RepositoryRealESFeature(MyDbContext b)
        {
            this.db = b;
        }
        public List<RealESFeature> CreateFeature(CreateVM vM, string RealESid)
        {
            var features = vM.Features
            .Where(x => x.isSelected == true)
            .Select(x => x.Id)
            .ToList();

            List<RealESFeature> r = new List<RealESFeature>();
            foreach (var fg in features)
            {
                r.Add(new RealESFeature
                {
                    FeatureID = fg,
                    RealESID = RealESid
                });
            }
            db.RealESFeatures.AddRangeAsync(r);



            return r;
        }
       
        public int UpdateFeature(CreateVM prop, string realid)
        {
            try
            {

                var features = prop.Features
           .Where(x => x.isSelected == true)
           .Select(x => x.Id)
           .ToList();
                List<RealESFeature> r = new List<RealESFeature>();
                foreach (var fg in features)
                {
                    r.Add(new RealESFeature { FeatureID = fg, RealESID = prop.IDRealES });

                }
                var real = db.RealES.Include(x => x.RealESFeatures).Where(x => x.ID == realid).FirstOrDefault();
                real.RealESFeatures = r;
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
