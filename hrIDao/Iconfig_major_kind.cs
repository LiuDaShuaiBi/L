using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Iconfig_major_kind:IBaseDao<config_major_kind>
    {
        string Max();
    }
}