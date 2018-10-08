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
        config_major_kindService cmks = new config_major_kindService();
        config_public_charService cps = new config_public_charService();
        human_fileService hfs = new human_fileService();
        major_changeService mcs = new major_changeService();
        salary_standardService sss = new salary_standardService();
        config_majorService cms = new config_majorService();
        config_primary_keyService cpks = new config_primary_keyService();
        human_file_digService hfds = new human_file_digService();

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
            int i = 0;
            List < major_change> li = mcs.Select();
            foreach (var item in li)
            {
                if (item.check_status == 1)
                    i++;
            }
            ViewData["i"] = i;
            ViewData.Model = li;

            return View();
        }
        public ActionResult check_success(major_change mc)
        {
            mcs.Upd(mc);
            return View();
        }
        public ActionResult detail(short id)
        {
            major_change mc = new major_change()
            {
                mch_id = id
            };
            ViewData.Model = mcs.SelectOne(mc);
            return View();
        }
        public ActionResult list(FormCollection fr)
        {
            string yi = fr["first_kind_id"];
            string er = fr["second_kind_id"];
            string san = fr["third_kind_id"];
            string zf = fr["major_kind_id"];
            string zm = fr["major_name"];
            ViewData.Model = mcs.Select();
            return View();
        }
        public ActionResult locate()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult register(short id)
        {
            ViewData["zw"] = cmks.Select();
            ViewData["yi"] = cffks.Select();
            ViewData["xc"] = sss.Select();
            human_file hf = new human_file()
            {
                huf_id = id
            };
            ViewData.Model = hfs.SelectOne(hf);
            return View();
        }
        public ActionResult register_list(FormCollection fr)
        {
            ViewData.Model = hfs.Select();
            //string yi = fr["configThird.firstKindId"];
            //string er = fr["configThird.secondKindId"];
            //string san = fr["configThird.thirdKindId"];
            //DateTime st = new DateTime();
            //DateTime et = DateTime.Now;
            //if (fr["utilbean.startDate"] != "")
            //    st = DateTime.Parse(fr["utilbean.startDate"]);
            //else
            //    st = DateTime.Parse("2011-1-1");
            //if (fr["utilbean.endDate"] != "")
            //    et = DateTime.Parse(fr["utilbean.endDate"]);
            //List<human_file> lh = new List<human_file>();
            //if (yi == "0")
            //{
            //    //查全部
            //    lh = hfs.selectYi("", st, et);
            //}
            //else if (yi != "0")
            //{
            //    lh = hfs.selectYi(yi, st, et);
            //}
            //else if (er == "0")
            //{
            //    lh = hfs.selectEr("", st, et);
            //}
            //else if (er != "0")
            //{
            //    lh = hfs.selectEr(er, st, et);
            //}
            //else if (san == "0")
            //{
            //    lh = hfs.selectBy("", st, et);
            //}
            //else
            //{
            //    lh = hfs.selectBy(san, st, et);
            //}
            //ViewData.Model = lh;
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