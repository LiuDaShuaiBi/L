using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Isalary_standard:IBaseDao<salary_standard>
    {
        string Max();
    }
}