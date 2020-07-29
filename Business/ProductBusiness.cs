using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class ProductBusiness
    {
        public static ProductEntity Get(string productId)
        {
            using InventaryContext db = new InventaryContext();
            return db.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public static List<ProductEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Products.ToList();
        }

        public static void Create(ProductEntity product)
        {
            using InventaryContext db = new InventaryContext();
            db.Products.Add(product);
            db.SaveChanges();
        }

        public static void Update(ProductEntity product)
        {
            using InventaryContext db = new InventaryContext();
            db.Products.Update(product);
            db.SaveChanges();
        }
    }
}
