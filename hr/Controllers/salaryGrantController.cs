using hrBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hrModel;

namespace hr.Controllers
{
    public class salaryGrantController : Controller
    {
        config_file_first_kindService cffks = new config_file_first_kindService();
        config_file_second_kindService cfsks = new config_file_second_kindService();
        config_file_third_kindService cftks = new config_file_third_kindService();
        // GET: salaryGrant
        public ActionResult check()
        {
            return View();
        }
        public ActionResult check_list()
        {
            return View();
        }
        public ActionResult check_success()
        {
            return View();
        }
        public ActionResult query()
        {
            return View();
        }
        public ActionResult query_list()
        {
            return View();
        }
        public ActionResult query_locate()
        {
            return View();
        }
        public ActionResult register_commit()
        {
            return View();
        }
        public ActionResult register_list()
        {
            string type = Request["submitType"];
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["type"] = type;
            return View();
        }
        public ActionResult register_locate()
        {
            return View();
        }
        public ActionResult register_success()
        {
            return View();
        }
    }
}