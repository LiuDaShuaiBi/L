using hrBLL;
using hrModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;

namespace hr.Controllers
{
    public class hrController : Controller
    {
        // GET: hr
        public ActionResult Index()
        {
            if (Session["user"] == null)
                Redirect("Login");
            return View();
        }
        public ActionResult Gun()
        {
            return View();
        }
        public ActionResult Left()
        {
            return View();
        }
        public ActionResult Mian()
        {
            return View();
        }
        public ActionResult top()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(users us)
        {
            UserService uss = new UserService();
            bool pd = uss.Login(us);
            if (pd)
                Session["user"] = uss.SelectBy(us);
            return Json(pd);
        }
    }
}