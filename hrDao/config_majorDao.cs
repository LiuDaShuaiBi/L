using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class config_majorDao: DaoBase<config_major>, Iconfig_major
    {
        public string Max()
        {
            string sql = string.Format("select MAX(major_kind_id )+1 from config_major ");
            string max = SqlHelper.selectone(sql).ToString();
            return max;
        }
    }
}