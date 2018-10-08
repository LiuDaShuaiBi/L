using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class salary_grantDao: DaoBase<salary_grant>, Isalary_grant
    {
        public DataTable Lyi()
        {
            string sql = "select [first_kind_name] as name,sum([salary_standard_sum]) as zjr,sum(human_amount) as rs from [dbo].[salary_grant] group by [first_kind_name]";
            return SqlHelper.selectDataTable(sql);
        }
        public DataTable Ler()
        {
            string sql = "select [second_kind_name] as name,sum([salary_standard_sum]) as zjr,sum(human_amount) as rs from [dbo].[salary_grant] group by [second_kind_name]";
            return SqlHelper.selectDataTable(sql);
        }
        public DataTable Lsan()
        {
            string sql = "select [third_kind_name] as name,sum([salary_standard_sum]) as zjr,sum(human_amount) as rs from [dbo].[salary_grant] group by [third_kind_name]";
            return SqlHelper.selectDataTable(sql);
        }

        public string Max()
        {
            string max = DateTime.Now.ToString("yyyyMMddHHmmss");
            Random ran = new Random();
            int n = ran.Next(100, 1000);
            max = "HS" + max + n;
            return max;
        }
    }
}