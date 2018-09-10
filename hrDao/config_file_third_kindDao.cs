using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class config_file_third_kindDao: DaoBase<config_file_third_kind>, Iconfig_file_third_kind
    {
        public string Max()
        {
            string sql = string.Format("select MAX(third_kind_id)+1 from config_file_third_kind ");
            string max = SqlHelper.selectone(sql).ToString();
            return max;
        }
    }
}