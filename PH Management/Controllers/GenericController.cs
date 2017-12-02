using PH_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PH_Management.Controllers
{
    public class GenericController : Controller
    {
        // GET: Generic
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult prGetEmployeeList()
        {            
            using (LoanAPPEntities dc = new LoanAPPEntities())
            {
                var result = dc.prGetEmployee("").ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult prGetProductList(string type )
        {
            using (LoanAPPEntities dc = new LoanAPPEntities())
            {
                var result = dc.prGetEmployee("").ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult prGetGroupDetails(string type)
        {
            using (LoanAPPEntities dc = new LoanAPPEntities())
            {
                var result = dc.prGetGroupDetails(type).ToList();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }


    }
}