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
public class engage_examService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_exam ist = db.Createengage_exam();
        public List<engage_exam> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_exam us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_exam us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_exam us)
        {
            return ist.Upd(us);
        }
        public engage_exam SelectOne(engage_exam us)
        {
            return ist.SelectBy(e=>e.exa_id==us.exa_id)[0];
        }
        
}

   
}