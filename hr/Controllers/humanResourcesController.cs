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
    public class humanResourcesController : Controller
    {
        config_file_first_kindService cffks = new config_file_first_kindService();
        config_file_second_kindService cfsks = new config_file_second_kindService();
        config_file_third_kindService cftks = new config_file_third_kindService();
        config_major_kindService cmks = new config_major_kindService();
        config_majorService cms = new config_majorService();
        config_public_charService cps = new config_public_charService();
        config_primary_keyService cpks = new config_primary_keyService();
        human_fileService hfs = new human_fileService();
        human_file_digService hfds = new human_file_digService();
        salary_standardService sss = new salary_standardService();

        // GET: humanResources
        public ActionResult change_keywords()
        {
            return View();
        }
        public ActionResult change_list(human_file hf)
        {
            ViewData.Model = hfs.Select();
            return View();
        }
        public ActionResult change_list_information(short id)
        {
            ViewData["yi"] = cffks.Select();
            ViewData["zwfl"] = cmks.Select();
            human_file hf = new human_file();
            hf.huf_id = id;
            ViewData.Model = hfs.SelectOne(hf);
            ViewData["gjz"] = cps.Select();
            return View();
        }
        public ActionResult change_locate()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult check_list()
        {
            ViewData.Model = hfs.Select();
            return View();
        }
        public ActionResult delete_forever_list()
        {
            ViewData.Model = hfs.Select();
            return View();
        }
        public ActionResult delete_keywords()
        {

            return View();
        }
        public ActionResult delete_list()
        {
            return View();
        }
        public ActionResult delete(short id)
        {
            human_file emr = new human_file();
            emr.huf_id = id;
            hfs.Del(emr);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
        public ActionResult delete_list_information()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult delete_locate()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData.Model = cps.Select();
            return View();
        }
        /// <summary>
        /// 复核
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult human_check(short id)
        {
            human_file hf = new human_file();
            hf.huf_id = id;
            ViewData.Model = hfs.SelectOne(hf);
            ViewData["gjz"] = cps.Select();
            return View();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        public ActionResult human_register()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData["zc"] = sss.Select();
            ViewData["id"] = hfs.Max();
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult query_keywords()
        {
            return View();
        }
        public ActionResult query_list()
        {
            ViewData.Model = hfs.Select();
            return View();
        }
        public ActionResult query_list_information(short id)
        {
            human_file hf = new human_file();
            hf.huf_id = id;
            ViewData.Model = hfs.SelectOne(hf);
            ViewData["gjz"] = cps.Select();
            return View();
        }
        public ActionResult query_locate()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult recovery_keywords()
        {
            return View();
        }
        public ActionResult recovery_list(human_file hf)
        {
            ViewData.Model = hfs.selectBy(hf.first_kind_name, hf.second_kind_name, hf.third_kind_name, hf.human_major_kind_name, hf.hunma_major_name);
            return View();
        }
        public ActionResult recovery_list_information(short id)
        {
            human_file hf = new human_file();
            hf.huf_id = id;
            ViewData.Model = hfs.SelectOne(hf);
            ViewData["gjz"] = cps.Select();
            return View();
        }
        public ActionResult recovery_locate()
        {
            ViewData["yi"] = cffks.Select();
            ViewData["er"] = cfsks.Select();
            ViewData["san"] = cftks.Select();
            ViewData["zwfl"] = cmks.Select();
            ViewData["zwmc"] = cms.Select();
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult register_choose_attachment()
        {
            return View();
        }
        public ActionResult register_choose_picture(human_file hf)
        {
            if (hf.huf_id == 0)
            {
                if (hfs.Add(hf))
                {
                    return Content(TcUlit.TC("成功", "check_list"));
                }
                else
                {
                    return Content(TcUlit.TC("失败", "check_list"));
                }
            }
            else
            {
                if (hfs.Upd(hf))
                {
                    return Content(TcUlit.TC("成功", "check_list"));
                }
                else
                {
                    return Content(TcUlit.TC("失败", "check_list"));
                }
            }

        }
        public ActionResult success()
        {
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
    }
}