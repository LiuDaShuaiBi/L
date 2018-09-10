using hr.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace hr
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ThreadPool.QueueUserWorkItem((a) => {
                while (true)
                {
                    if (CExceptionFilter.qd.Count() > 0)
                    {
                        Exception ex = CExceptionFilter.qd.Dequeue();//从队列里取值
                        if (ex != null)
                        {
                            //把异常写成日志
                            using (StreamWriter sw = new StreamWriter(@"D:\资料\Y2\服务器控件\项目\项目静态资料\ecshop\Admin\images\日志错误.txt", true))
                            {
                                sw.WriteLine("错误时间:" + DateTime.Now);
                                sw.WriteLine("错误内容:" + ex.Message);
                                sw.WriteLine("错误的文件:Program.cs");
                                sw.WriteLine("--------------------");
                            }
                            //LogHelper.WriteLog(typeof(CExceptionFilter), ex);

                        }
                        else
                        {
                            Thread.Sleep(3000);//让线程休眠3秒钟
                        }

                    }
                    else
                    {
                        Thread.Sleep(3000);//让线程休眠3秒钟
                    }
                }

            });
        }
    }
}
