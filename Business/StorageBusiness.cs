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
        public static StorageEntity Get(int id)
        {
            using InventaryContext db = new InventaryContext();
            return db.Storages.FirstOrDefault(storage => storage.StorageId == id);
        }

        public static List<StorageEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.Storages.ToList();
        }

        public static void Create(StorageEntity storage)
        {
            storage.LastUpdate = DateTime.Now;
            using InventaryContext db = new InventaryContext();
            db.Storages.Add(storage);
            db.SaveChanges();
        }

        public static void Update(StorageEntity storage)
        {
            using InventaryContext db = new InventaryContext();
            db.Storages.Update(storage);
            db.SaveChanges();
        }
    }
}
