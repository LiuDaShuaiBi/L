using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Iengage_resume:IBaseDao<engage_resume>
    {
        bool xg(short id,short st);
        
    }
}