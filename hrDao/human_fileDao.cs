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
    public class human_fileDao: DaoBase<human_file>, Ihuman_file
    {
        public string Max()
        {
            string max = DateTime.Now.ToString("yyyyMMddHHmmss");
            Random ran = new Random();
            int n = ran.Next(100, 1000);
            max = "bt"+  max + n;
            //string sql = string.Format("select MAX(human_id) from human_file");
            //string max = SqlHelper.selectone(sql).ToString();
            //string q = max.Substring(0, 2);
            //string h = max.Substring(3);
            //int ih = int.Parse(h)+1;
            //max = q + ih.ToString();
            return max;
        }
        public bool updatahf(major_change mc,short id)
        {
            string sql = string.Format("update [dbo].[human_file] set [first_kind_id]='{0}',[first_kind_name]='{1}',[second_kind_id]='{2}',[second_kind_name]='{3}',[third_kind_id]='{4}',[third_kind_name]='{5}',salary_standard_id='{6}',[salary_standard_name]='{7}' where [huf_id]='{8}'",
                mc.new_first_kind_id,mc.new_first_kind_name,mc.new_second_kind_id,mc.new_second_kind_name,mc.new_third_kind_id
                ,mc.new_third_kind_name,mc.major_id,mc.major_name,id);
            return SqlHelper.zsg(sql)>0;
        }
        public DataTable Lyi()
        {
            string sql = "select [first_kind_name] as name,sum(salary_sum) as zjr,count(0) as rs from [human_file] group by [first_kind_name]";
            return SqlHelper.selectDataTable(sql);
        }
        public DataTable Ler()
        {
            string sql = "select [second_kind_name] as name,sum(salary_sum) as zjr,count(0) as rs from [human_file] group by [second_kind_name]";
            return SqlHelper.selectDataTable(sql);
        }
        public DataTable Lsan()
        {
            string sql = "select [third_kind_name] as name,sum(salary_sum) as zjr,count(0) as rs from [human_file] group by [third_kind_name]";
            return SqlHelper.selectDataTable(sql);
        }
        hr_dbEntities se = new hr_dbEntities();
        public List<View_GZ> Lv()
        {
            List<View_GZ> lv =se.Set<View_GZ>().Select(e => e).ToList();
            return lv;
        }
    }
}