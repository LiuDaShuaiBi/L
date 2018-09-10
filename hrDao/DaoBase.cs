using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class DaoBase<T> where T :class
    {
        hr_dbEntities se = new hr_dbEntities();
        public List<T> Select()
        {
            return se.Set<T>().Select(e => e).ToList();
        }
        public List<T> SelectBy(Expression<Func<T, bool>> where)
        {
            return se.Set<T>().Select(e => e).Where(where).ToList();
        }
        public bool Add(T t)
        {
            se.Set<T>().Add(t);
            return se.SaveChanges() > 0;
            //return true;
        }
        public bool Upd(T t)
        {
            se.Entry<T>(t).State = System.Data.Entity.EntityState.Modified;
            return se.SaveChanges() > 0;
            //return true;
        }
        public bool Del(T t)
        {
            se.Entry<T>(t).State = System.Data.Entity.EntityState.Deleted;
            return se.SaveChanges() > 0;
            //return true;
        }
    }
}
