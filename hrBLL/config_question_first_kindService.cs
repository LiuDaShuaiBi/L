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
public class config_question_first_kindService
    {
static DBSessionFactory db = new DBSessionFactory();
        Iconfig_question_first_kind ist = db.Createconfig_question_first_kind();
        public List<config_question_first_kind> Select()
        {
            return ist.Select();
        }
        
        public bool Del(config_question_first_kind us)
        {
            return ist.Del(us);
        }
        public bool Add(config_question_first_kind us)
        {
            return ist.Add(us);
        }
        public bool Upd(config_question_first_kind us)
        {
            return ist.Upd(us);
        }
        public config_question_first_kind SelectOne(config_question_first_kind us)
        {
            return ist.SelectBy(e=>e.qfk_id==us.qfk_id)[0];
        }
        
}

   
}