using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RESProject.Repositories.Entities.Category
{
    internal interface IRepositoryCategory
    {
        public List<SelectionFeatures> GetCategories4CreateOrIndex();
        public List<SelectListItem> GetCategory4Select();
    }
}
