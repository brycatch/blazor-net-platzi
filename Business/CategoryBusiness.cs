using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class CategoryBusiness
    {
        public List<CategoryEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Categories.ToList();
        }

        public void Create(CategoryEntity category)
        {
            using InventaryContext db = new InventaryContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Update(CategoryEntity category)
        {
            using InventaryContext db = new InventaryContext();
            db.Categories.Update(category);
            db.SaveChanges();
        }
    }
}
