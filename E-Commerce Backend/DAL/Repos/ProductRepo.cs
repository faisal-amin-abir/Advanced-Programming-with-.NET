using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductRepo : Repo, IRepo<Product, int, Product>
    {
        public Product Create(Product Obj)
        {
            db.Products.Add(Obj);
            if (db.SaveChanges() > 0) return Obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Products.Remove(ex);
            return (db.SaveChanges() > 0);
        }

        public List<Product> Read()
        {
            return db.Products.ToList();
        }

        public Product Read(int Id)
        {
            return 
                db.Products.Find(Id);
        }

        public Product Update(Product Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0) return Obj;
            return null;
        }
    }
}
