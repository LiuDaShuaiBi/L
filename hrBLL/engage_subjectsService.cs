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
public class engage_subjectsService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_subjects ist = db.Createengage_subjects();
        public List<engage_subjects> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_subjects us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_subjects us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_subjects us)
        {
            return ist.Upd(us);
        }
        public engage_subjects SelectOne(engage_subjects us)
        {
            return ist.SelectBy(e=>e.sub_id==us.sub_id)[0];
        }
        
}

   
}