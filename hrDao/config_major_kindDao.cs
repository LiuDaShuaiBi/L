using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class config_major_kindDao: DaoBase<config_major_kind>, Iconfig_major_kind
    {
        public string Max()
        {
            string sql = string.Format("select MAX(major_kind_id)+1 from config_major_kind ");
            string max = SqlHelper.selectone(sql).ToString();
            return max;
        }
    }
}