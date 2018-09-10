using hrDao;
using hrIDao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBsession
{
    public class DBSessionFactory
    {
        public IUser CreateUser()
        {
            return new UserDao();
        }
        public Ibonus Createbonus()
        {
            return new bonusDao();
        }
        public Iconfig_file_first_kind Createconfig_file_first_kind()
        {
            return new config_file_first_kindDao();
        }
        public Iconfig_file_second_kind Createconfig_file_second_kind()
        {
            return new config_file_second_kindDao();
        }
        public Iconfig_file_third_kind Createconfig_file_third_kind()
        {
            return new config_file_third_kindDao();
        }
        public Iconfig_major_kind Createconfig_major_kind()
        {
            return new config_major_kindDao();
        }
        public Iconfig_major Createconfig_major()
        {
            return new config_majorDao();
        }
        public Iconfig_primary_key Createconfig_primary_key()
        {
            return new config_primary_keyDao();
        }
        public Iconfig_public_char Createconfig_public_char()
        {
            return new config_public_charDao();
        }
        public Iconfig_question_first_kind Createconfig_question_first_kind()
        {
            return new config_question_first_kindDao();
        }
        public Iconfig_question_second_kind Createconfig_question_second_kind()
        {
            return new config_question_second_kindDao();
        }
        public Iengage_answer_details Createengage_answer_details()
        {
            return new engage_answer_detailsDao();
        }
        public Iengage_answer Createengage_answer()
        {
            return new engage_answerDao();
        }
        public Iengage_exam_details Createengage_exam_details()
        {
            return new engage_exam_detailsDao();
        }
        public Iengage_exam Createengage_exam()
        {
            return new engage_examDao();
        }
        public Iengage_interview Createengage_interview()
        {
            return new engage_interviewDao();
        }
        public Iengage_major_release Createengage_major_release()
        {
            return new engage_major_releaseDao();
        }
        public Iengage_resume Createengage_resume()
        {
            return new engage_resumeDao();
        }
        public Iengage_subjects Createengage_subjects()
        {
            return new engage_subjectsDao();
        }
        public Ihuman_file_dig Createhuman_file_dig()
        {
            return new human_file_digDao();
        }
        public Ihuman_file Createhuman_file()
        {
            return new human_fileDao();
        }
        public Imajor_change Createmajor_change()
        {
            return new major_changeDao();
        }
        public Isalary_grant_details Createsalary_grant_details()
        {
            return new salary_grant_detailsDao();
        }
        public Isalary_grant Createsalary_grant()
        {
            return new salary_grantDao();
        }
        public Isalary_standard_details Createsalary_standard_details()
        {
            return new salary_standard_detailsDao();
        }
        public Isalary_standard Createsalary_standard()
        {
            return new salary_standardDao();
        }
        public Itraining Createtraining()
        {
            return new trainingDao();
        }




        DbContext n = DBContextFactory.CreateDBContext();
        public bool SavChange()
        {
            bool re = false;
            try
            {
                re = n.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                getex(ex);
            }
            return re;
        }
        private static void getex(Exception ex)
        {

            using (StreamWriter sw = new StreamWriter(@"D:\资料\Y2\服务器控件\项目\项目静态资料\ecshop\Admin\images\日志错误.txt", true))
            {
                sw.WriteLine("错误时间:" + DateTime.Now);
                sw.WriteLine("错误内容:" + ex.Message);
                sw.WriteLine("错误的文件:Program.cs");
                sw.WriteLine("--------------------");
            }
        }
    }
}
