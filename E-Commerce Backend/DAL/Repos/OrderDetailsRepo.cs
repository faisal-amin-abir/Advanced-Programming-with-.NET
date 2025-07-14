using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderDetailsRepo : Repo, IRepo<OrderDetails, int, bool>
    {
        public bool Create(OrderDetails Obj)
        {
            db.OrderDetails.Add(Obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.OrderDetails.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<OrderDetails> Read()
        {
            return db.OrderDetails.ToList();
        }

        public OrderDetails Read(int Id)
        {
            return db.OrderDetails.Find(Id);
        }

        public bool Update(OrderDetails Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            return db.SaveChanges() > 0;
        }
    }
}
