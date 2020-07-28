using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class StorageBusiness
    {
        public List<StorageEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Storages.ToList();
        }

        public void Create(StorageEntity storage)
        {
            using InventaryContext db = new InventaryContext();
            db.Storages.Add(storage);
            db.SaveChanges();
        }

        public void Update(StorageEntity storage)
        {
            using InventaryContext db = new InventaryContext();
            db.Storages.Update(storage);
            db.SaveChanges();
        }
    }
}
