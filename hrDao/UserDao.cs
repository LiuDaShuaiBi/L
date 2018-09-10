using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class UserDao : DaoBase<users>, IUser
    {
        hr_dbEntities se = new hr_dbEntities();
        public bool Login(users us)
        {
            string sql = string.Format("select * from users where u_name='{0}' and u_password='{1}'",us.u_name,us.u_password);
            var res = se.users.SqlQuery(sql).Count();
            return res>0;
        }
    }
}
