using hrBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hrModel;
using System.Data;
using Newtonsoft.Json;

namespace hr.Controllers
{
    public class salaryGrantController : Controller
    {
        config_file_first_kindService cffks = new config_file_first_kindService();
        config_file_second_kindService cfsks = new config_file_second_kindService();
        config_file_third_kindService cftks = new config_file_third_kindService();
        salary_grantService sgs = new salary_grantService();
        salary_grant_detailsService sgds = new salary_grant_detailsService();
        salary_standard_detailsService ssds = new salary_standard_detailsService();
        human_fileService hfs = new human_fileService();


        // GET: salaryGrant
        public ActionResult check(string id)
        {
            salary_grant sg = sgs.SelectOne(id);
            List<salary_standard_details> lssd = new List<salary_standard_details>();
            lssd = ssds.Select();
            List<salary_grant_details> lsgd = sgds.SelectBy(id);
            return View(Tuple.Create(sg, lssd,lsgd));
        }
        public ActionResult check_list()
        {
            ViewData.Model = sgs.Select();
            return View();
        }
        public ActionResult check_success(salary_grant sg, FormCollection fc)
        {
            for (int i = 0; i < sg.human_amount; i++)
            {
                string s = fc["grantDetails[" + i + "].human_id"];
                string human_name = fc["grantDetails[" + i + "].human_name"];
                decimal bouns_sum = decimal.Parse(fc["grantDetails[" + i + "].bounsSum"]);
                decimal deduct_sum = decimal.Parse(fc["grantDetails[" + i + "].deductSum"]);
                decimal sale_sum = decimal.Parse(fc["grantDetails[" + i + "].saleSum"]);
                decimal salary_paid_sum = decimal.Parse(fc["grantDetails[" + i + "].salaryPaidSum"]);

                decimal salary_standard_sum = decimal.Parse(fc["grantDetails[" + i + "].salary_standard_sum"]);
                salary_grant_details sgd = new salary_grant_details()
                {
                    grd_id=short.Parse(fc["grantDetails[" + i + "].grd_id"]),
                    human_id = s,
                    human_name = human_name,
                    bouns_sum = bouns_sum,
                    deduct_sum = deduct_sum,
                    sale_sum = sale_sum,
                    salary_paid_sum = salary_paid_sum,
                    salary_grant_id = sg.salary_grant_id,
                    salary_standard_sum = salary_standard_sum
                };
                sgds.Upd(sgd);
            }
            sgs.Upd(sg);
            return View();
        }
        public ActionResult query(string id)
        {
            salary_grant sg = sgs.SelectOne(id);
            
            List<salary_grant_details> lsgd = sgds.SelectBy(id);
            return View(Tuple.Create(sg,  lsgd));
        }
        public ActionResult query_list(FormCollection fr)
        {
            string id = fr["salaryGrantId"];
            DateTime st = new DateTime();
            DateTime et = DateTime.Now;
            if (fr["utilbean.startDate"] != "")
                st = DateTime.Parse(fr["utilbean.startDate"]);
            else
                st = DateTime.Parse("2011-1-1");
            if (fr["utilbean.endDate"] != "")
                et = DateTime.Parse(fr["utilbean.endDate"]);
            ViewData.Model = sgs.selectBy(id, st, et);
            return View();
        }
        public ActionResult query_locate()
        {

            return View();
        }
        public ActionResult register_commit()
        {
            string type = Request["type"];
            string name = Request["name"];
            string sgid = sgs.Max();
            List<human_file> list = new List<human_file>();
            if (type == "1")
            {
                list = hfs.Oyi(name);
            }
            if (type == "2")
            {
                list = hfs.Oer(name);
            }
            if (type == "3")
            {
                list = hfs.Osan(name);
            }
            List<salary_grant_details> lsgd = new List<salary_grant_details>();
            List<salary_standard_details> lssd = new List<salary_standard_details>();
            lssd = ssds.Select();
            decimal sum = 0;
            foreach (human_file item in list)
            {
                sum += (decimal)item.salary_sum;
                if (type == "1")
                {
                    ViewData["yid"] = item.first_kind_id;
                    ViewData["yname"] = item.first_kind_name;
                }
                if (type == "2")
                {
                    ViewData["yid"] = item.first_kind_id;
                    ViewData["yname"] = item.first_kind_name;
                    ViewData["eid"] = item.second_kind_id;
                    ViewData["ename"] = item.second_kind_name;
                }
                if (type == "3")
                {
                    ViewData["yid"] = item.first_kind_id;
                    ViewData["yname"] = item.first_kind_name;
                    ViewData["eid"] = item.second_kind_id;
                    ViewData["ename"] = item.second_kind_name;
                    ViewData["sid"] = item.third_kind_id;
                    ViewData["sname"] = item.third_kind_name;
                }
            }
            ViewData["sum"] = sum;
            ViewData["id"] = sgid;
            return View(Tuple.Create(list, lssd));
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

        public JsonResult L()
        {
            string type = Request["type"];
            if (type == "1")
            {
                DataTable d = hfs.Lyi();
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                var ret = JsonConvert.SerializeObject(d, setting);
                return Json(ret, JsonRequestBehavior.AllowGet);
            }
            else if (type == "2")
            {
                DataTable d = hfs.Ler();
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                var ret = JsonConvert.SerializeObject(d, setting);
                return Json(ret, JsonRequestBehavior.AllowGet);
            }
            else
            {
                DataTable d = hfs.Lsan();
                JsonSerializerSettings setting = new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                var ret = JsonConvert.SerializeObject(d, setting);
                return Json(ret, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult register_locate()
        {
            return View();
        }
        public ActionResult register_success(salary_grant sg, FormCollection fc)
        {

            for (int i = 0; i < sg.human_amount; i++)
            {
                string s = fc["grantDetails[" + i + "].human_id"];
                string human_name = fc["grantDetails[" + i + "].human_name"];
                decimal bouns_sum = decimal.Parse(fc["grantDetails[" + i + "].bounsSum"]);
                decimal deduct_sum = decimal.Parse(fc["grantDetails[" + i + "].deductSum"]);
                decimal sale_sum = decimal.Parse(fc["grantDetails[" + i + "].saleSum"]);
                decimal salary_paid_sum = decimal.Parse(fc["grantDetails[" + i + "].salaryPaidSum"]);

                decimal salary_standard_sum = decimal.Parse(fc["grantDetails[" + i + "].salary_standard_sum"]);
                salary_grant_details sgd = new salary_grant_details()
                {
                    human_id = s,
                    human_name = human_name,
                    bouns_sum = bouns_sum,
                    deduct_sum = deduct_sum,
                    sale_sum = sale_sum,
                    salary_paid_sum = salary_paid_sum,
                    salary_grant_id = sg.salary_grant_id,
                    salary_standard_sum = salary_standard_sum
                };
                sgds.Add(sgd);
            }
            sgs.Add(sg);
            return View();
        }
    }
}