using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Repositories.Entities
{
    public interface IRepositoryRealES
    {
        public  Task<List<RealES>> listRealEs();
        public  Task<RealES> GetById(string id);
        public int Create(CreateVM v, string UserId);
        public  Task<int> Update(CreateVM v);
        public int Delete(string id);

    }
}
