using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Iconfig_file_third_kind:IBaseDao<config_file_third_kind>
    {
        string Max();
    }
}