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
public class salary_standardService
    {
static DBSessionFactory db = new DBSessionFactory();
        Isalary_standard ist = db.Createsalary_standard();
        public List<salary_standard> Select()
        {
            return ist.Select();
        }
        
        public bool Del(salary_standard us)
        {
            return ist.Del(us);
        }
        public bool Add(salary_standard us)
        {
            return ist.Add(us);
        }
        public bool Upd(salary_standard us)
        {
            return ist.Upd(us);
        }
        public salary_standard SelectOne(salary_standard us)
        {
            return ist.SelectBy(e=>e.standard_id==us.standard_id)[0];
        }
        public string Max()
        {
            return ist.Max();
        }
        public List<salary_standard> selectBy(string id,DateTime stime,DateTime etime)
        {
            if(id!="")
                return ist.SelectBy(e => e.standard_id == id);
            else
            {
                return ist.SelectBy(e => e.regist_time>stime&e.regist_time<etime);
            }
        }
    }

   
}