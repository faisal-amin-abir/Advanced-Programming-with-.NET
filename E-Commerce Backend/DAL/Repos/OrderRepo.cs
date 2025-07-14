using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : Repo, IRepo<Order, int, bool>
    {
        public bool Create(Order Obj)
        {
            db.Orders.Add(Obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Orders.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Order> Read()
        {
            return db.Orders.ToList();
        }

        public Order Read(int Id)
        {
            return db.Orders.Find(Id);
        }

        public bool Update(Order Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            return db.SaveChanges() > 0;
        }
    }
}
