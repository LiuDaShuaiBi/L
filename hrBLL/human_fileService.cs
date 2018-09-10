using DBsession;
using hrIDao;
using hrModel;
using System;
using System.Collections.Generic;
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
        public List<human_file> selectBy(string san, DateTime jdsj, DateTime cxsj)
        {

            return ist.SelectBy(e => e.third_kind_name.Contains(san) & e.regist_time >= jdsj & e.regist_time <= cxsj);
        }
        public string Max()
        {
            return ist.Max();
        }
    }
}