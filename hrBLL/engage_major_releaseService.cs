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
public class engage_major_releaseService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_major_release ist = db.Createengage_major_release();
        public List<engage_major_release> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_major_release us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_major_release us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_major_release us)
        {
            return ist.Upd(us);
        }
        public engage_major_release SelectOne(engage_major_release us)
        {
            return ist.SelectBy(e=>e.mre_id==us.mre_id)[0];
        }
        
}

   
}