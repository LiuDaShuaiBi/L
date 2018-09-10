using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hrBLL;
using hrModel;

namespace hr.Controllers
{
    public class clientController : Controller
    {
        config_file_second_kindService cfsks = new config_file_second_kindService();
        config_file_first_kindService cffks = new config_file_first_kindService();
        config_file_third_kindService cftks = new config_file_third_kindService();
        config_major_kindService cmks = new config_major_kindService();
        config_public_charService cps = new config_public_charService();
        config_primary_keyService spks = new config_primary_keyService();


        config_majorService cms = new config_majorService();
        public ActionResult first_delete_success(int id)
        {
            config_file_first_kind cffk = new config_file_first_kind()
            {
                ffk_id = id
            };
            if (cffks.Del(cffk))
                return View();
            else
                return RedirectToAction("first_kind");
        }
        public ActionResult first_kind()
        {
            ViewData.Model = cffks.Select();
            return View();
        }
        public ActionResult first_kind_change(short id)
        {
            config_file_first_kind cffk = new config_file_first_kind()
            {
                ffk_id = id
            };
            config_file_first_kind cff = cffks.SelectOne(cffk);
            ViewData.Model = cff;
            return View();
        }
        public ActionResult first_kind_change_success(FormCollection frm)
        {
            config_file_first_kind cffk = new config_file_first_kind()
            {
                ffk_id = int.Parse(frm["ffk_id"]),
                first_kind_id= frm["first_kind_id"],
                first_kind_name = frm["first_kind_name"],
                first_kind_salary_id = frm["first_kind_salary_id"],
                 first_kind_sale_id = frm["first_kind_sale_id"],
            };
            bool pd = cffks.Upd(cffk);
            if(pd)
                return View();
            else
                return RedirectToAction("first_kind");
        }
        public ActionResult first_kind_register()
        {
            string max= cffks.Max();
            ViewData["id"] = max;
            return View();
        }
        public ActionResult first_kind_register_success(config_file_first_kind cffk)
        {
            bool pd = cffks.Add(cffk);
            if (pd)
                return View();
            else
                return RedirectToAction("first_kind");
        }
        [HttpGet]
        public ActionResult major()
        {
            ViewData.Model = cms.Select();
            return View();
        }
        [HttpPost]
        public ActionResult major(config_major cm)
        {
            cms.Add(cm);
            ViewData.Model = cms.Select();
            return View();
        }
        public JsonResult major_delete(short id)
        {
            config_major cm = new config_major()
            {
                mak_id = id
            };
            return Json(cms.Del(cm));
        }

        public ActionResult major_add()
        {
            return View();
        }
        [HttpGet]
        public ActionResult major_kind()
        {
            ViewData.Model = cmks.Select();
            return View();
        }
        [HttpPost]
        public ActionResult major_kind(config_major_kind cmk)
        {
            cmks.Add(cmk);
            ViewData.Model = cmks.Select();
            return View();
        }
        public JsonResult major_kind_delete(short id)
        {
            config_major_kind cm = new config_major_kind()
            {
                mfk_id = id
            };
            return Json(cmks.Del(cm));
        }
        public ActionResult major_kind_add()
        {
            ViewData["id"] = cmks.Max();
            return View();
        }
        public ActionResult primary_key()
        {
            ViewData.Model = spks.Select();
            return View();
        }
        [HttpPost]
        public ActionResult primary_key(config_primary_key cpk)
        {
            ViewData.Model = spks.Select();
            return View();
        }
        public ActionResult primary_key_register(FormCollection fcr)
        {
            string name=fcr["primaryKeyTable"];
            ViewData.Model = spks.SelectBy(name);
            return View();
        }
        public ActionResult profession_design()
        {
            ViewData.Model = cms.Select();
            return View();
        }
        
        public ActionResult public_char()
        {
            ViewData.Model = cps.Select();
            return View();
        }
        [HttpPost]
        public ActionResult public_char(config_public_char cpc)
        {
            cps.Add(cpc);
            ViewData.Model = cps.Select();
            return View();
        }
        public ActionResult public_char_add()
        {
            return View();
        }
        public JsonResult public_char_delete(short id)
        {
            config_public_char cpc = new config_public_char()
            {
                pbc_id = id
            };
            bool res = cps.Del(cpc);
            return Json(res);
        }
        public ActionResult salary_grant_mode()
        {
            return View();
        }
        public ActionResult salary_grant_mode_success()
        {
            return View();
        }
        public ActionResult salary_item()
        {
            return View();
        }
        public ActionResult salary_item_register()
        {
            return View();
        }
        public ActionResult second_delete_success(short id)
        {
            config_file_second_kind cffk = new config_file_second_kind()
            {
                fsk_id = id
            };
            bool pd = cfsks.Del(cffk);
            if (pd)
                return View();
            else
                return RedirectToAction("second_kind");
        }
        public ActionResult second_kind()
        {
            ViewData.Model = cfsks.Select();
            return View();
        }
        public ActionResult second_kind_change(short id)
        {
            config_file_second_kind cffk = new config_file_second_kind()
            {
                 fsk_id = id
            };
            config_file_second_kind cff = cfsks.SelectOne(cffk);
            ViewData.Model = cff;
            return View();
        }
        public ActionResult second_kind_change_success(config_file_second_kind cffk)
        {
            bool pd = cfsks.Upd(cffk);
            if (pd)
                return View();
            else
                return RedirectToAction("second_kind");
        }
        public ActionResult second_kind_register()
        {
            ViewData["fk"] = cffks.Select();
            string max = cfsks.Max();
            ViewData["id"] = max;
            return View();
        }
        public ActionResult second_kind_register_success(config_file_second_kind cfsk)
        {
            bool pd = cfsks.Add(cfsk);
            if (pd)
                return View();
            else
                return RedirectToAction("second_kind");
        }
        public ActionResult third_delete_success(short id)
        {
            config_file_third_kind cffk = new config_file_third_kind()
            {
                ftk_id = id
            };
            bool pd = cftks.Del(cffk);
            if (pd)
                return View();
            else
                return RedirectToAction("third_kind");
        }
        public ActionResult third_kind()
        {
            ViewData.Model = cftks.Select();
            return View();
        }
        public ActionResult third_kind_change(short id)
        {
            config_file_third_kind cffk = new config_file_third_kind()
            {
                ftk_id = id
            };
            config_file_third_kind cff = cftks.SelectOne(cffk);
            ViewData.Model = cff;
            return View();
        }
        public ActionResult third_kind_change_success(config_file_third_kind cffk)
        {
            bool pd = cftks.Upd(cffk);
            if (pd)
                return View();
            else
                return RedirectToAction("third_kind");
        }
        public ActionResult third_kind_register()
        {
            ViewData["sk"] = cfsks.Select();
            ViewData["fk"] = cffks.Select();
            string max = cfsks.Max();
            ViewData["id"] = max;
            return View();
        }
        public ActionResult third_kind_register_success(config_file_third_kind cftk)
        {
            bool pd = cftks.Add(cftk);
            if (pd)
                return View();
            else
                return RedirectToAction("third_kind");
        }
    }
}