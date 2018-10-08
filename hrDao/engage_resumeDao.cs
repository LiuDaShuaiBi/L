using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class engage_resumeDao : DaoBase<engage_resume>, Iengage_resume
    {
        public bool xg(short id,short st)
        {
            string sql = string.Format("update [dbo].[engage_resume] set [check_status]={0} where [res_id]={1}",st,id);
            int p = SqlHelper.zsg(sql);
            return p > 0;
        }
    }
}