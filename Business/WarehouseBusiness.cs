using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class WarehouseBusiness
    {
        public static WarehouseEntity Get(string id)
        {
            using InventaryContext db = new InventaryContext();
            return db.Warehouses.FirstOrDefault(warehouse => warehouse.WarehouseId == id);
        }

        public static List<WarehouseEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Warehouses.ToList();
        }

        public static void Create(WarehouseEntity warehouse)
        {
            using InventaryContext db = new InventaryContext();
            db.Warehouses.Add(warehouse);
            db.SaveChanges();
        }

        public static void Update(WarehouseEntity warehouse)
        {
            using InventaryContext db = new InventaryContext();
            db.Warehouses.Update(warehouse);
            db.SaveChanges();
        }
    }
}
