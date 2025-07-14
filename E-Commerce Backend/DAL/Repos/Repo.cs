using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    
    internal class Repo
    {
        internal ProductContext db;
        internal Repo()
        {
            db = new ProductContext();
        }
    }
}
