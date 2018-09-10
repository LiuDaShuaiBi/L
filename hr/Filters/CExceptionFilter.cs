using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Filters
{
    public class CExceptionFilter : ActionFilterAttribute, IExceptionFilter
    {
        public static Queue<Exception> qd = new Queue<Exception>();
        public void OnException(ExceptionContext filterContext)
        {
            //1 捕捉异常
            Exception ex = filterContext.Exception;
            qd.Enqueue(ex);//进入队列
                           //2 跳转提示页面
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            //3 告诉系统不需要处理异常了
            filterContext.ExceptionHandled = true;
        }
    }
}