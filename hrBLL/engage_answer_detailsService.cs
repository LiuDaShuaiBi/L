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
public class engage_answer_detailsService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_answer_details ist = db.Createengage_answer_details();
        public List<engage_answer_details> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_answer_details us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_answer_details us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_answer_details us)
        {
            return ist.Upd(us);
        }
        public engage_answer_details SelectOne(engage_answer_details us)
        {
            return ist.SelectBy(e=>e.and_id==us.and_id)[0];
        }
        
}

   
}