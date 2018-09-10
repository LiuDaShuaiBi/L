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
    public class config_primary_keyService
    {
        static DBSessionFactory db = new DBSessionFactory();
        Iconfig_primary_key ist = db.Createconfig_primary_key();
        public List<config_primary_key> Select()
        {
            return ist.Select();
        }

        public bool Del(config_primary_key us)
        {
            return ist.Del(us);
        }
        public bool Add(config_primary_key us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_primary_key us)
        {
            return ist.Upd(us);
        }
        public config_primary_key SelectOne(config_primary_key us)
        {
            return ist.SelectBy(e => e.prk_id == us.prk_id)[0];
        }
        public List<config_primary_key> SelectBy(string tablename)
        {
            return ist.SelectBy(e => e.primary_key_table == tablename);
        }

    }
}