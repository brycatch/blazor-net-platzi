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
        public static CategoryEntity Get(string id)
        {
            using InventaryContext db = new InventaryContext();
            return db.Categories.FirstOrDefault(c => c.CategoryId == id);
        }

        public static List<CategoryEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Categories.ToList();
        }

        public static void Create(CategoryEntity category)
        {
            using InventaryContext db = new InventaryContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public static void Update(CategoryEntity category)
        {
            using InventaryContext db = new InventaryContext();
            db.Categories.Update(category);
            db.SaveChanges();
        }
    }
}
