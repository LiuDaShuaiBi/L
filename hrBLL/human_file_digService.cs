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
public class human_file_digService
    {
static DBSessionFactory db = new DBSessionFactory();
        Ihuman_file_dig ist = db.Createhuman_file_dig();
        public List<human_file_dig> Select()
        {
            return ist.Select();
        }
        
        public bool Del(human_file_dig us)
        {
            return ist.Del(us);
        }
        public bool Add(human_file_dig us)
        {
            return ist.Add(us);
        }
        public bool Upd(human_file_dig us)
        {
            return ist.Upd(us);
        }
        public human_file_dig SelectOne(human_file_dig us)
        {
            return ist.SelectBy(e=>e.hfd_id==us.hfd_id)[0];
        }
        
}

   
}