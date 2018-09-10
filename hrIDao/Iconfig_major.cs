using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Iconfig_major:IBaseDao<config_major>
    {
        string Max();
    }
}