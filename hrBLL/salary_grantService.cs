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
public class salary_grantService
    {
static DBSessionFactory db = new DBSessionFactory();
        Isalary_grant ist = db.Createsalary_grant();
        public List<salary_grant> Select()
        {
            return ist.Select();
        }
        
        public bool Del(salary_grant us)
        {
            return ist.Del(us);
        }
        public bool Add(salary_grant us)
        {
            return ist.Add(us);
        }
        public bool Upd(salary_grant us)
        {
            return ist.Upd(us);
        }
        public salary_grant SelectOne(salary_grant us)
        {
            return ist.SelectBy(e=>e.salary_grant_id==us.salary_grant_id)[0];
        }
       
}

   
}