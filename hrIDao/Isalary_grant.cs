using hrModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrIDao
{
    public interface Isalary_grant : IBaseDao<salary_grant>
    {
        DataTable Lyi();
        DataTable Ler();
        DataTable Lsan();
        string Max();
    }
}