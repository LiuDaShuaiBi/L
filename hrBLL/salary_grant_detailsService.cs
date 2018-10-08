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
    public class salary_grant_detailsService
    {
        static DBSessionFactory db = new DBSessionFactory();
        Isalary_grant_details ist = db.Createsalary_grant_details();
        public List<salary_grant_details> Select()
        {
            return ist.Select();
        }

        public bool Del(salary_grant_details us)
        {
            return ist.Del(us);
        }
        public bool Add(salary_grant_details us)
        {
            return ist.Add(us);
        }
        public bool Upd(salary_grant_details us)
        {
            return ist.Upd(us);
        }
        public salary_grant_details SelectOne(salary_grant_details us)
        {
            return ist.SelectBy(e => e.grd_id == us.grd_id)[0];
        }
        public List<salary_grant_details> SelectBy(string id)
        {
            return ist.SelectBy(e => e.salary_grant_id == id);
        }
    }
}