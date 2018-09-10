using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class config_file_first_kindDao : DaoBase<config_file_first_kind>, Iconfig_file_first_kind
    {
        hr_dbEntities hd = new hr_dbEntities();
        public bool Adda(config_file_first_kind cf)
        {
            string sql = string.Format("insert into [dbo].[config_file_first_kind](first_kind_id, first_kind_name, first_kind_salary_id, first_kind_sale_id) values('{0}','{1}','{2}','{3}') ",cf.first_kind_id,cf.first_kind_name,cf.first_kind_salary_id,cf.first_kind_sale_id);
            return SqlHelper.zsg(sql) > 0;
        }
        public string Max()
        {
            string sql = string.Format("select MAX(first_kind_id)+1 from config_file_first_kind ");
            string max = SqlHelper.selectone(sql).ToString();
            return max;
        }
    }
}