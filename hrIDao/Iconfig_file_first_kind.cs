using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Iconfig_file_first_kind:IBaseDao<config_file_first_kind>
    {
        string Max();
        bool Adda(config_file_first_kind c);
    }
}