using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
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
    }
}