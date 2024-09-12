using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Repositories.Entities
{
    public interface IRepositoryRealESFeature
    {
        public List<RealESFeature> CreateFeature(CreateVM vM, string RealESid);
        public int UpdateFeature(CreateVM vM, string realid);

        

      
    }
}
