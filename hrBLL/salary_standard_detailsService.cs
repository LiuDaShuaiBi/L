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
public class salary_standard_detailsService
    {
static DBSessionFactory db = new DBSessionFactory();
        Isalary_standard_details ist = db.Createsalary_standard_details();
        public List<salary_standard_details> Select()
        {
            return ist.Select();
        }
        
        public bool Del(salary_standard_details us)
        {
            return ist.Del(us);
        }
        public bool Add(salary_standard_details us)
        {
            return ist.Add(us);
        }
        public bool Upd(salary_standard_details us)
        {
            return ist.Upd(us);
        }
        public salary_standard_details SelectOne(salary_standard_details us)
        {
            return ist.SelectBy(e=>e.standard_id==us.standard_id)[0];
        }
        public List<salary_standard_details> SelectBy(string id)
        {
            return ist.SelectBy(e => e.standard_id == id);
        }

}

   
}