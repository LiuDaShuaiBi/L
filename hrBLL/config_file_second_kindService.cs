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
public class config_file_second_kindService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iconfig_file_second_kind ist = db.Createconfig_file_second_kind();
        public List<config_file_second_kind> Select()
        {
            return ist.Select();
        }
        
        public bool Del(config_file_second_kind us)
        {
            return ist.Del(us);
        }
        public bool Add(config_file_second_kind us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_file_second_kind us)
        {
            return ist.Upd(us);
        }
        public config_file_second_kind SelectOne(config_file_second_kind us)
        {
            return ist.SelectBy(e=>e.fsk_id==us.fsk_id)[0];
        }
        public string Max()
        {
            return ist.Max();
        }
        public List<config_file_second_kind> erSelect(string id)
        {
            return ist.SelectBy(e => e.first_kind_id == id);
        }
    }

   
}