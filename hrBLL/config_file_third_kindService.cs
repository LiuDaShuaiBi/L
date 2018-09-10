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
public class config_file_third_kindService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iconfig_file_third_kind ist = db.Createconfig_file_third_kind();
        public List<config_file_third_kind> Select()
        {
            return ist.Select();
        }
        
        public bool Del(config_file_third_kind us)
        {
            return ist.Del(us);
        }
        public bool Add(config_file_third_kind us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_file_third_kind us)
        {
            return ist.Upd(us);
        }
        public config_file_third_kind SelectOne(config_file_third_kind us)
        {
            return ist.SelectBy(e=>e.ftk_id==us.ftk_id)[0];
        }
        public string Max()
        {
            return ist.Max();
        }
        public List<config_file_third_kind> sanSelect(string id)
        {
            return ist.SelectBy(e => e.second_kind_id == id);
        }
    }

   
}