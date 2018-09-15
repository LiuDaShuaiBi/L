using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrDao
{
    public class SqlHelper
    {
        //1 连接字符串
        static string conStr = @"Data Source=.;Initial Catalog=hr_db;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        public static int zsg(string sql, params SqlParameter[] ps)
        {
            int result = 0;
            SqlConnection cn = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps.Length > 0)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {
                //5 打开连接
                cn.Open();
                //6 命令对象.ExecuteNonQuery
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                getex(ex);
                //LogHelper.WriteLog(typeof(SqlHelper), ex);
                //Console.WriteLine("系统很忙，晚点再试");
            }
            finally
            {
                //7 关闭连接
                cn.Close();
            }
            return result;
        }

        private static void getex(Exception ex)
        {

            using (StreamWriter sw = new StreamWriter(@"C:\Users\小可爱\Desktop\错误日志.txt", true))
            {
                sw.WriteLine("错误时间:" + DateTime.Now);
                sw.WriteLine("错误内容:" + ex.Message);
                sw.WriteLine("错误的文件:Program.cs");
                sw.WriteLine("--------------------");
            }
        }

        public static object selectone(string sql, params SqlParameter[] ps)
        {
            object obj = null;

            SqlConnection cn = new SqlConnection(conStr);

            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps.Length > 0)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {

                cn.Open();

                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                getex(ex);

            }
            finally
            {


                cn.Close();
            }
            return obj;
        }

        public static SqlDataReader selectReader(string sql, params SqlParameter[] ps)
        {
            SqlDataReader reader = null;

            //2 连接对象
            SqlConnection cn = new SqlConnection(conStr);
            //3 查多个值

            //4 生成命令对象
            SqlCommand cmd = new SqlCommand(sql, cn);
            if (ps.Length > 0)
            {
                cmd.Parameters.AddRange(ps);
            }
            try
            {
                //5 打开连接
                cn.Open();
                //6 命令对象.ExecuteReader()
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {

                getex(ex);
            }

            return reader;
        }

        public static DataTable selectDataTable(string sql, params SqlParameter[] ps)
        {
            //1 连接字符串

            //2 连接对象
            SqlConnection cn = new SqlConnection(conStr);
            //4 生成适配器对象
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
         
            if (ps.Length > 0)
            {
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            //5 生成DataTable对象
            DataTable dt = new DataTable();
            //6 适配器对象.Fill(DataTable对象)
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {

                getex(ex);
            }
            return dt;
        }
        public static DataTable Proc(string sql, params SqlParameter[] ps)
        {
            //1 连接字符串

            //2 连接对象
            SqlConnection cn = new SqlConnection(conStr);
            //4 生成适配器对象
            SqlDataAdapter ad = new SqlDataAdapter(sql, cn);
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (ps.Length > 0)
            {
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            //5 生成DataTable对象
            DataTable dt = new DataTable();
            //6 适配器对象.Fill(DataTable对象)
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {

                getex(ex);
            }
            return dt;
        }
    }
}
