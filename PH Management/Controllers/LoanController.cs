using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PH_Management.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        public ActionResult NewLoan()
        {
            return View();
        }
    }
}