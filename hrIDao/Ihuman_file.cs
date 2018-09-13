using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Ihuman_file:IBaseDao<human_file>
    {
        string Max();
        bool updatahf(major_change mc);
    }
}