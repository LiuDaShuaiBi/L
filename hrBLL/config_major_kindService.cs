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
public class config_major_kindService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iconfig_major_kind ist = db.Createconfig_major_kind();
        public List<config_major_kind> Select()
        {
            return ist.Select();
        }
        
        public bool Del(config_major_kind us)
        {
            return ist.Del(us);
        }
        public bool Add(config_major_kind us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_major_kind us)
        {
            return ist.Upd(us);
        }
        public config_major_kind SelectOne(config_major_kind us)
        {
            return ist.SelectBy(e=>e.mfk_id==us.mfk_id)[0];
        }
        public string Max()
        {
            return ist.Max();
        }
    }

   
}