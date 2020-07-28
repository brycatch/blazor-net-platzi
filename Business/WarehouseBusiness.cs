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
        public List<WarehouseEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Warehouses.ToList();
        }

        public void Create(WarehouseEntity warehouse)
        {
            using InventaryContext db = new InventaryContext();
            db.Warehouses.Add(warehouse);
            db.SaveChanges();
        }

        public void Update(WarehouseEntity warehouse)
        {
            using InventaryContext db = new InventaryContext();
            db.Warehouses.Update(warehouse);
            db.SaveChanges();
        }
    }
}
