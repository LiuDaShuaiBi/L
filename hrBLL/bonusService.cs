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
public class bonusService
    {
static DBSessionFactory db = new DBSessionFactory();
        Ibonus ist = db.Createbonus();
        public List<bonus> Select()
        {
            return ist.Select();
        }
        
        public bool Del(bonus us)
        {
            return ist.Del(us);
        }
        public bool Add(bonus us)
        {
            return ist.Add(us);
        }
        public bool Upd(bonus us)
        {
            return ist.Upd(us);
        }
        public bonus SelectOne(bonus us)
        {
            return ist.SelectBy(e=>e.bon_id==us.bon_id)[0];
        }
        
}

   
}