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
        human_fileService hfs = new human_fileService();
        major_changeService mcs = new major_changeService();
        salary_standardService sss = new salary_standardService();
        config_majorService cms = new config_majorService();

        // GET: transfer
        public ActionResult check(short id)
        {
            ViewData["xc"] = sss.Select();
            ViewData["yi"] = cffks.Select();
            ViewData["zw"] = cms.Select();
            major_change hf = new major_change()
            {
                mch_id = id
            };
            ViewData.Model = mcs.SelectOne(hf);
            return View();
        }
        public ActionResult check_list()
        {
            ViewData.Model = mcs.Select();
            return View();
        }
        public ActionResult check_success(major_change mc)
        {
            mcs.Upd(mc);
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
        public ActionResult register(short id)
        {

            ViewData["yi"] = cffks.Select();
            human_file hf = new human_file()
            {
                huf_id = id
            };
            ViewData.Model = hfs.SelectOne(hf);
            return View();
        }
        public ActionResult register_list(FormCollection fr)
        {
            string yi = fr["configThird.firstKindId"];
            string er = fr["configThird.secondKindId"];
            string san = fr["configThird.thirdKindId"];
            DateTime st = new DateTime();
            DateTime et = DateTime.Now;
            if (fr["utilbean.startDate"] != "")
                st = DateTime.Parse(fr["utilbean.startDate"]);
            else
                st = DateTime.Parse("2011-1-1");
            if (fr["utilbean.endDate"] != "")
                et = DateTime.Parse(fr["utilbean.endDate"]);
            List<human_file> lh = new List<human_file>();
            if (yi == "0")
            {
                //查全部
                lh = hfs.selectYi("", st, et);
            }
            else if (yi != "0")
            {
                lh = hfs.selectYi(yi, st, et);
            }
            else if (er == "0")
            {
                lh = hfs.selectEr("", st, et);
            }
            else if (er != "0")
            {
                lh = hfs.selectEr(er, st, et);
            }
            else if (san == "0")
            {
                lh = hfs.selectBy("", st, et);
            }
            else
        {
                lh = hfs.selectBy(san, st, et);
            }
            ViewData.Model = lh;
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
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult san()
        {
            string id = Request["id"];
            List<config_file_third_kind> list = cftks.sanSelect(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult zw()
        {
            string id = Request["id"];
            List<config_major> list = cms.SelectX(id);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public ActionResult xc()
        {
            short id = short.Parse(Request["id"]);
            string cx = sss.SelectSum(id);
            return Json(cx, JsonRequestBehavior.AllowGet);
        }
        public ActionResult register_success(major_change mc)
        { 
            mcs.Add(mc);
            short id = short.Parse(Request["huf_id"]);
            hfs.DD(mc,id);
            return View();
        }

    }
}