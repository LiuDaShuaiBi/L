using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface IBaseDao<T> where T :class
    {
        bool Add(T t);
        bool Del(T t);
        bool Upd(T t);
        List<T> Select();
        List<T> SelectBy(Expression<Func<T, bool>> where);
    }
}
