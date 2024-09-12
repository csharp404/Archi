using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using RESProject.Models.Models;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESProject.Repositories.Entities
{
    public interface IRepositoryRoom
    {
        public int Create(Room room,string RealESid);
        public int Update(CreateVM Upadte, string realid);

    }
}
