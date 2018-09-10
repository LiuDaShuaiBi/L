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
public class engage_interviewService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_interview ist = db.Createengage_interview();
        public List<engage_interview> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_interview us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_interview us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_interview us)
        {
            return ist.Upd(us);
        }
        public engage_interview SelectOne(engage_interview us)
        {
            return ist.SelectBy(e=>e.ein_id==us.ein_id)[0];
        }
       
}

   
}