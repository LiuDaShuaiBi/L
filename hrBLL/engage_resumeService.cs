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
public class engage_resumeService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_resume ist = db.Createengage_resume();
        public List<engage_resume> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_resume us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_resume us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_resume us)
        {
            return ist.Upd(us);
        }
        public engage_resume SelectOne(engage_resume us)
        {
            return ist.SelectBy(e=>e.res_id==us.res_id)[0];
        }
        public List<engage_resume> selectBy(string us,DateTime startDate,DateTime endDate)
        {

            return ist.SelectBy(e =>  e.human_major_id==us&e.regist_time > startDate&e.regist_time < endDate);
        }
}

   
}