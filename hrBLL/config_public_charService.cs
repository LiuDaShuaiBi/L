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
public class config_public_charService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iconfig_public_char ist = db.Createconfig_public_char();
        public List<config_public_char> Select()
        {
            return ist.Select();
        }
        
        public bool Del(config_public_char us)
        {
            return ist.Del(us);
        }
        public bool Add(config_public_char us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_public_char us)
        {
            return ist.Upd(us);
        }
        public config_public_char SelectOne(config_public_char us)
        {
            return ist.SelectBy(e=>e.pbc_id==us.pbc_id)[0];
        }
        
}

   
}