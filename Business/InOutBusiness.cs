using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class InOutBusiness
    {
        public List<InOutEntity> List()
        {
            using InventaryContext db = new InventaryContext();
            return db.InOuts.ToList();
        }

        public void Create(InOutEntity inOut)
        {
            using InventaryContext db = new InventaryContext();
            db.InOuts.Add(inOut);
            db.SaveChanges();
        }

        public void Update(InOutEntity inOut)
        {
            using InventaryContext db = new InventaryContext();
            db.InOuts.Update(inOut);
            db.SaveChanges();
        }
    }
}
