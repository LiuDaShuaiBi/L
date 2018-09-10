using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hrBLL;
using hrModel;
namespace hr.Controllers
{
    public class salaryCriterionController : Controller
    {
        salary_standardService sss = new salary_standardService();
        config_public_charService cpcs = new config_public_charService();
        salary_standard_detailsService ssds = new salary_standard_detailsService();

        // GET: salaryCriterion
        public ActionResult salarystandard_change(string id)
        {
            salary_standard ssb = new salary_standard() { standard_id = id };
            List<salary_standard_details> ssd = ssds.SelectBy(id);
            salary_standard ss = sss.SelectOne(ssb);
            return View(Tuple.Create(ss, ssd));
        }
        public ActionResult salarystandard_change_list(FormCollection fr)
        {
            string id = fr["standard_id"];
            DateTime st = new DateTime();
            DateTime et = DateTime.Now;
            if (fr["utilbean.startDate"] != "")
                st = DateTime.Parse(fr["utilbean.startDate"]);
            else
                st = DateTime.Parse("2011-1-1");
            if (fr["utilbean.endDate"] != "")
                et = DateTime.Parse(fr["utilbean.endDate"]);
            ViewData.Model = sss.selectBy(id, st, et);
            return View();
        }
        //chaxun
        public ActionResult salarystandard_change_locate()
        {

            return View();
        }
        //变更
        public ActionResult salarystandard_change_success(salary_standard ss, FormCollection fc)
        {
            List<string> ls = new List<string>();
            for (int i = 1; i < 7; i++)
            {
                short id = short.Parse(fc["details[" + i + "].sdtId"]);
                short o = short.Parse(fc["details[" + i + "].itemId"]);
                string d = fc["details[" + i + "].itemName"];
                decimal s = decimal.Parse(fc["details[" + i + "].salary"]);
                salary_standard_details ssd = new salary_standard_details()
                {
                    standard_id = ss.standard_id,
                    item_name = d,
                    item_id = o,
                    standard_name = ss.standard_name,
                    salary = s,
                    sdt_id=id
                };
                ssds.Upd(ssd);
            }
            sss.Upd(ss);
            return View();
        }
        public ActionResult salarystandard_check(string id)
        {
            salary_standard ssb = new salary_standard() { standard_id = id };
            List <salary_standard_details> ssd = ssds.SelectBy(id);
            salary_standard ss = sss.SelectOne(ssb);
            return View(Tuple.Create(ss, ssd));
        }
        public ActionResult salarystandard_check_list()
        {
            ViewData.Model = sss.Select();
            //salary_standard ssb = new salary_standard() { standard_id=id};
            return View();
        }
        public ActionResult salarystandard_check_success(salary_standard ss)
        {
            sss.Upd(ss);
            return View();
        }
        public ActionResult salarystandard_query(string id)
        {
            salary_standard ssb = new salary_standard() { standard_id = id };
            List<salary_standard_details> ssd = ssds.SelectBy(id);
            salary_standard ss = sss.SelectOne(ssb);
            return View(Tuple.Create(ss, ssd));
        }
        public ActionResult salarystandard_query_list(FormCollection fr)
        {
            string id = fr["standard_id"];
            DateTime st = new DateTime();
            DateTime et = DateTime.Now;
            if (fr["utilbean.startDate"] != "")
                st = DateTime.Parse(fr["utilbean.startDate"]);
            else
                st = DateTime.Parse("2011-1-1");
            if (fr["utilbean.endDate"] != "")
                et = DateTime.Parse(fr["utilbean.endDate"]);
            ViewData.Model = sss.selectBy(id, st, et);
            return View();
        }
        public ActionResult salarystandard_query_locate()
        {

            return View();
        }
        public ActionResult salarystandard_register()
        {
            ViewData["max"] = sss.Max();
            ViewData["int"] = 0;
            ViewData.Model = cpcs.Select();
            return View();
        }
        public ActionResult salarystandard_register_success(salary_standard ss,FormCollection fc)
        {
            //List<config_public_char> lcpc = cpcs.Select();
            List<string> ls = new List<string>();
            for (int i = 1; i < 7; i++)
            {
                short o = short.Parse(fc["details[" + i + "].item_id"]);
                string d= fc["details[" + i + "].itemName"];
                decimal s= decimal.Parse(fc["details[" + i + "].salary"]);
                salary_standard_details ssd = new salary_standard_details()
                {
                    standard_id=ss.standard_id,
                    item_name=d,
                    item_id=o,
                    standard_name=ss.standard_name,
                    salary=s
                };
                ssds.Add(ssd);
            }
            sss.Add(ss);
            return View();
        }
    }
}