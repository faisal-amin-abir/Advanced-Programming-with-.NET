using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, int, User>
    {
        public User Create(User Obj)
        {
            db.Users.Add(Obj);
            if (db.SaveChanges() > 0) return Obj;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Users.Remove(ex);
            return (db.SaveChanges() > 0);
        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(int Id)
        {
            var ret = db.Users.Find(Id);
            return ret;
        }

        public User Update(User Obj)
        {
            var ex = Read(Obj.Id);
            db.Entry(ex).CurrentValues.SetValues(Obj);
            if (db.SaveChanges() > 0) return Obj;
            return null;
        }
    }
}
