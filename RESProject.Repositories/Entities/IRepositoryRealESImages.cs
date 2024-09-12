using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Repositories.Entities
{
    public interface IRepositoryRealESImages
    {
        public List<RealESImages> CreateImages(CreateVM v, string RealESid);
     
    }
}
