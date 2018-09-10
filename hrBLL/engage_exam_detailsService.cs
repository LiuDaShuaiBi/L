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
public class engage_exam_detailsService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iengage_exam_details ist = db.Createengage_exam_details();
        public List<engage_exam_details> Select()
        {
            return ist.Select();
        }
        
        public bool Del(engage_exam_details us)
        {
            return ist.Del(us);
        }
        public bool Add(engage_exam_details us)
        {
            return ist.Add(us);
        }
        public bool Upd(engage_exam_details us)
        {
            return ist.Upd(us);
        }
        public engage_exam_details SelectOne(engage_exam_details us)
        {
            return ist.SelectBy(e=>e.exd_id==us.exd_id)[0];
        }
        
}

   
}