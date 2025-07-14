using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<Type, ID, RET>
    {
        RET Create(Type Obj);
        List<Type> Read();
        Type Read(ID Id);
        bool Delete(ID id);

        RET Update(Type Obj);
    }
}
