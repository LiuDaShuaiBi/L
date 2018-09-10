using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class salary_standardDao : DaoBase<salary_standard>, Isalary_standard
    {
        public string Max()
        {
            string sql = string.Format("select CONVERT(bigint,MAX(standard_id))+1 from salary_standard");
            string max = SqlHelper.selectone(sql).ToString();
            return max;
        }
    }
}