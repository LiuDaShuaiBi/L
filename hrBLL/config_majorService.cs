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
public class config_majorService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iconfig_major ist = db.Createconfig_major();
        public List<config_major> Select()
        {
            return ist.Select();
        }
        
        public bool Del(config_major us)
        {
            return ist.Del(us);
        }
        public bool Add(config_major us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_major us)
        {
            return ist.Upd(us);
        }
        public config_major SelectOne(config_major us)
        {
            return ist.SelectBy(e=>e.major_id==us.major_id)[0];
        }
        public string Max()
        {
            return ist.Max();
        }
        public List<config_major> SelectX(string id)
        {
            return ist.SelectBy(e => e.major_kind_id == id);
        }
    }

   
}