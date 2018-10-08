using DBsession;
using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Data;
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
        public salary_grant SelectOne(string us)
        {
            return ist.SelectBy(e => e.salary_grant_id == us)[0];
        }
        public DataTable Lyi()
        {
            return ist.Lyi();
        }
        public DataTable Ler()
        {
            return ist.Ler();
        }
        public DataTable Lsan()
        {
            return ist.Lsan();
        }
        public List<salary_grant> Oyi(string name)
        {
            return ist.SelectBy(e => e.first_kind_name == name);
        }
        public List<salary_grant> Oer(string name)
        {
            return ist.SelectBy(e => e.second_kind_name == name);
        }
        public List<salary_grant> Osan(string name)
        {
            return ist.SelectBy(e => e.third_kind_name == name);
        }
        public string Max()
        {
            return ist.Max();
        }
        public List<salary_grant> selectBy(string id, DateTime stime, DateTime etime)
        {
            if (id != "")
                return ist.SelectBy(e => e.salary_grant_id == id);
            else
            {
                return ist.SelectBy(e => e.regist_time > stime & e.regist_time < etime);
            }
        }
    }


}