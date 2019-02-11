using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTEL.Classes.Crud
{
    public interface IOtelRep<T> where T:DbObject
    {
        List<T> Listeleme { get; }
        bool Insert(T Entity);
        bool Delete(T Entity);
        bool Delete(string ID);
        bool Update(T Entity);
        bool Update(string ID);
        T Find(string ID);
    }
}
