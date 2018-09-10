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
    public class major_changeService
    {
        static DBSessionFactory db = new DBSessionFactory();
        Imajor_change ist = db.Createmajor_change();
        public List<major_change> Select()
        {
            return ist.Select();
        }

        public bool Del(major_change us)
        {
            return ist.Del(us);
        }
        public bool Add(major_change us)
        {
            return ist.Add(us);
        }
        public bool Upd(major_change us)
        {
            return ist.Upd(us);
        }
        public major_change SelectOne(major_change us)
        {
            return ist.SelectBy(e => e.mch_id == us.mch_id)[0];
        }

    }


}