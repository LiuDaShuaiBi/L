using DBsession;
using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrBLL
{
    public class human_fileService
    {
        static DBSessionFactory db = new DBSessionFactory();
        Ihuman_file ist = db.Createhuman_file();
        public List<human_file> Select()
        {
            return ist.Select();
        }

        public bool Del(human_file us)
        {
            return ist.Del(us);
        }
        public bool Add(human_file us)
        {
            return ist.Add(us);
        }
        public bool Upd(human_file us)
        {
            return ist.Upd(us);
        }
        public human_file SelectOne(human_file us)
        {
            return ist.SelectBy(e => e.huf_id == us.huf_id)[0];
        }
        public List<human_file> selectBy(string yi, string er, string san, string zwfl, string zwmc)
        {

            return ist.SelectBy(e => e.first_kind_name.Contains(yi) & e.second_kind_name.Contains(er) & e.third_kind_name.Contains(san) & e.human_major_kind_name.Contains(zwfl) & e.hunma_major_name.Contains(zwmc));
        }
        /// <summary>
        /// 三级查询
        /// </summary>
        /// <param name="san"></param>
        /// <param name="jdsj"></param>
        /// <param name="cxsj"></param>
        /// <returns></returns>
        public List<human_file> selectBy(string san, DateTime jdsj, DateTime cxsj)
        {
            return ist.SelectBy(e => e.third_kind_name.Contains(san) & e.regist_time >= jdsj & e.regist_time <= cxsj);
        }
        /// <summary>
        /// 二级查询
        /// </summary>
        /// <param name="san"></param>
        /// <param name="jdsj"></param>
        /// <param name="cxsj"></param>
        /// <returns></returns>
        public List<human_file> selectEr(string san, DateTime jdsj, DateTime cxsj)
        {
            return ist.SelectBy(e => e.salary_standard_id.Contains(san) & e.regist_time >= jdsj & e.regist_time <= cxsj);
        }
        /// <summary>
        /// 一级查询
        /// </summary>
        /// <param name="san"></param>
        /// <param name="jdsj"></param>
        /// <param name="cxsj"></param>
        /// <returns></returns>
        public List<human_file> selectYi(string san, DateTime jdsj, DateTime cxsj)
        {
            return ist.SelectBy(e => e.first_kind_id.Contains(san) & e.regist_time >= jdsj & e.regist_time <= cxsj);
        }
        public string Max()
        {
            return ist.Max();
        }
        public bool DD(major_change mc,short id)
        {
            return ist.updatahf(mc,id);
        }
        public DataTable Lyi()
        {
            return ist.Lyi();
        }
        public DataTable Ler()
        {
            return ist.Ler();
        }
        public DataTable Lsan()
        {
            return ist.Lsan();
        }
        public List<human_file> Oyi(string name)
        {
            return ist.SelectBy(e => e.first_kind_name == name);
        }
        public List<human_file> Oer(string name)
        {
            return ist.SelectBy(e => e.second_kind_name == name);
        }
        public List<human_file> Osan(string name)
        {
            return ist.SelectBy(e => e.third_kind_name == name);
        }
    }
}