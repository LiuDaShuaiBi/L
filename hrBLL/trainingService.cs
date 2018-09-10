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
public class trainingService
    {
static DBSessionFactory db = new DBSessionFactory();
        Itraining ist = db.Createtraining();
        public List<training> Select()
        {
            return ist.Select();
        }
        
        public bool Del(training us)
        {
            return ist.Del(us);
        }
        public bool Add(training us)
        {
            return ist.Add(us);
        }
        public bool Upd(training us)
        {
            return ist.Upd(us);
        }
        public training SelectOne(training us)
        {
            return ist.SelectBy(e=>e.tra_id==us.tra_id)[0];
        }
        
}

   
}