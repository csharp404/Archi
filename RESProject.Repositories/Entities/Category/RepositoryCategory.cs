using RESProject.DataAccess.Data;
using RESProject.Models.ViewModels.RealESVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RESProject.Repositories.Entities.Category
{
    internal class RepositoryCategory : IRepositoryCategory
    {
        private readonly MyDbContext db;

        public RepositoryCategory(MyDbContext db)
        {
            this.db= db;    
        }
        //for filtering
        public List<SelectionFeatures> GetCategories4CreateOrIndex()
        {
            var data = db.Categories.Select(x => new SelectionFeatures { Id = x.ID, Name = x.Name, isSelected = false }).ToList();
        return data;
                }
        //for dropdownlist
        public List<SelectListItem> GetCategory4Select()
        {
            var types = db.Categories.ToList();
            List < SelectListItem > Categories = types.Select(x => new SelectListItem { Text = x.Name, Value = x.ID }).ToList();
            return Categories;
        }
    }
}
