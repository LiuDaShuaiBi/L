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
public class engage_answerService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_answer ist = db.Createengage_answer();
        public List<engage_answer> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_answer us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_answer us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_answer us)
        {
            return ist.Upd(us);
        }
        public engage_answer SelectOne(engage_answer us)
        {
            return ist.SelectBy(e=>e.ans_id==us.ans_id)[0];
        }
        
}

   
}