using DBsession;
using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrBLL
{
    public class UserService
    {
        static DBSessionFactory db = new DBSessionFactory();
        IUser ist = db.CreateUser();
        public List<users> Select()
        {
            return ist.Select();
        }
        public bool Login(users us)
        {
            return ist.Login(us);
        }
        public bool Del(users us)
        {
            return ist.Del(us);
        }
        public bool Add(users us)
        {
            return ist.Add(us);
        }
        public bool Upd(users us)
        {
            return ist.Upd(us);
        }
        public users SelectOne(users us)
        {
            return ist.SelectBy(e=>e.u_id==us.u_id)[0];
        }
        public users SelectBy(users us)
        {
            return ist.SelectBy(e => e.u_name == us.u_name&e.u_password==us.u_password)[0];
        }
    }
}
