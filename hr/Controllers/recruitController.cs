using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hrBLL;
using hrModel;
using Common;

namespace hr.Controllers
{
    public class recruitController : Controller
    {
        config_file_first_kindService cffks = new config_file_first_kindService();
        config_file_second_kindService cfsks = new config_file_second_kindService();
        config_file_third_kindService cftks = new config_file_third_kindService();
        engage_major_releaseService emrs = new engage_major_releaseService();
        config_major_kindService cmks = new config_major_kindService();
        config_majorService cms = new config_majorService();
        config_public_charService cpcs = new config_public_charService();
        engage_resumeService ers = new engage_resumeService();
        human_fileService hfs = new human_fileService();
        engage_interviewService eis = new engage_interviewService();

        // GET: recruit
        public ActionResult check()
        {
            return View();
        }
        public ActionResult check_list()
        {
            return View();
        }
        public ActionResult details()
        {
            return View();
        }
        public ActionResult list()
        {
            return View();
        }
        public ActionResult register()
        {
            ViewData["zwf"] = cmks.Select();
            ViewData["zw"] = cms.Select();
            ViewData.Model = cpcs.Select();
            return View();
        }
        public ActionResult register_add(engage_resume er)
        {
            ers.Add(er);
            return Content(TcUlit.TC("添加成功", "/recruit/register"));
        }
        public ActionResult register_list()
        {
            ViewData.Model = ers.Select();
            return View();
        }
        public ActionResult interview_list()
        {
            ViewData.Model = ers.Select();
            return View();
        }
        public ActionResult interview_register(short id)
        {
            engage_resume hf = new engage_resume()
            {
                res_id = id
            };
            ViewData.Model = ers.SelectOne(hf);
            return View();
        }
        public ActionResult interview_add(engage_interview ei,human_file  hf)
        {
            eis.Add(ei);
           // hfs.Add(hf);
            return Content(TcUlit.TC("面试成功", "/recruit/interview_list"));
        }
        public ActionResult interview_upd(engage_interview ei)
        {
            ei.human_name= Request["human_name"];
            eis.Upd(ei);
            return Content(TcUlit.TC("筛选成功", "/recruit/sift_list"));
        }
        public ActionResult interview_resume()
        {
            return View();
        }
        public ActionResult interview_sift(short id)
        {
            engage_resume hf = new engage_resume()
            {
                res_id = id
            };
            engage_interview ei = new engage_interview()
            {
                ein_id = id
            };
            engage_resume er = ers.SelectOne(hf);
            engage_interview eiw = eis.SelectOne(ei);
            return View(Tuple.Create(er, eiw));
        }
        public ActionResult sift_list()
        {
            ViewData.Model =eis.Select();
            return View();
        }
        public ActionResult position_change_update()
        {
            ViewData.Model = emrs.Select();
            return View();
        }
        [HttpPost]
        public ActionResult position_change_update(engage_major_release emr)
        {
            if (emr.mre_id == 0)
                emrs.Add(emr);
            else
                emrs.Upd(emr);
            ViewData.Model = emrs.Select();
            return View();
        }
        public ActionResult position_register()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwf"] = cmks.Select();
            ViewData["zw"] = cms.Select();
            return View();
        }
        public ActionResult position_release_change(short id)
        {
            engage_major_release emr = new engage_major_release()
            {
                mre_id = id
            };
            ViewData.Model = emrs.SelectOne(emr);
            return View();
        }
        public ActionResult position_release_details()
        {
            return View();
        }
        public ActionResult position_release_search()
        {
            ViewData.Model = emrs.Select();
            return View();
        }
        public ActionResult resume(FormCollection fr)
        {
            string mid = fr["human_major_id"];
            DateTime st=new DateTime();
            DateTime et=DateTime.Now;
            if (fr["startDate"] != "")
                st = DateTime.Parse(fr["startDate"]);
            else
                st = DateTime.Parse("2011-1-1");
            if (fr["endDate"] != "")
                et = DateTime.Parse(fr["endDate"]);
            ViewData.Model = ers.selectBy(mid, st, et);
            return View();
        }
        public ActionResult resume_choose()
        {
            ViewData["zwf"] = cmks.Select();
            ViewData["zw"] = cms.Select();
            return View();
        }
        public ActionResult resume_details()
        {
            return View();
        }
        public ActionResult resume_list()
        {
            return View();
        }
        public ActionResult resume_register()
        {
            return View();
        }
        public ActionResult resume_select()
        {
            return View();
        }
        public ActionResult valid_list()
        {
            ViewData["zwf"] = cmks.Select();
            ViewData["zw"] = cms.Select();
            return View();
        }
        public ActionResult valid_resume()
        {
            ViewData["zwf"] = cmks.Select();
            ViewData["zw"] = cms.Select();
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
    }
}