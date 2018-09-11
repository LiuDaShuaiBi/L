using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hrBLL;
using hrModel;

namespace hr.Controllers
{
    public class transferController : Controller
    {
        config_file_first_kindService cffks = new config_file_first_kindService();
        config_file_second_kindService cfsks = new config_file_second_kindService();
        config_file_third_kindService cftks = new config_file_third_kindService();
        // GET: transfer
        public ActionResult check()
        {
            string lksb = "";
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
        public ActionResult detail()
        {
            return View();
        }
        public ActionResult list()
        {
            return View();
        }
        public ActionResult locate()
        {
            return View();
        }
        public ActionResult register()
        {
            return View();
        }
        public ActionResult register_list()
        {
            return View();
        }
        public ActionResult register_locate()
        {
            ViewData["yi"] = cffks.Select();
            return View();
        }
        public ActionResult er()
        {
            string id = Request["id"];
            List<config_file_second_kind> list = cfsks.erSelect(id);
            return Json(list,JsonRequestBehavior.AllowGet);
        }
        public ActionResult san()
        {
            string id = Request["id"];
            List<config_file_third_kind> list = cftks.sanSelect(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult register_success()
        {
            return View();
        }
    }
}