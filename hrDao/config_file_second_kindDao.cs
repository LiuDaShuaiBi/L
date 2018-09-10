using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class config_file_second_kindDao: DaoBase<config_file_second_kind>, Iconfig_file_second_kind
    {
        public string Max()
        {
            string sql = string.Format("select MAX(second_kind_id)+1 from config_file_second_kind ");
            string max = SqlHelper.selectone(sql).ToString();
            return max;
        }
    }
}