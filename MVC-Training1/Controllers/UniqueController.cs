using MVC_Training1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Training1.Controllers
{
    public class UniqueController : Controller
    {
        // GET: Unique
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Unique model)
        {
            int num = model.Number;
            HashSet<char> uniqueDigits = new HashSet<char>();

            foreach (char digit in num.ToString())
            {
                if (!uniqueDigits.Contains(digit))
                {
                    uniqueDigits.Add(digit);
                }
            }
            ViewBag.UniqueDigits = (uniqueDigits);
            return View();
        }
    }
}