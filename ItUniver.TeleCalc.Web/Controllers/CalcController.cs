using ItUniver.TeleCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItUniver.TeleCalc.Web.Controllers
{
    public class CalcController : Controller
    {
    [HttpGet]
        public ActionResult Index(String operName, Double? x, Double? y)
        {
            var calc = new Calc();    
 
                ViewBag.Result = calc.Exec(operName, x, y);
                ViewBag.OperName = operName;
                ViewBag.DataX = x;
                ViewBag.DataY = y;

            return View();
        }

        public ActionResult Operation()
        {
            var calc = new Calc();    
 
            foreach(string elem in calc.GetOpers)
            {
                ViewBag.opers += elem + "\t";
            }

            return View();
        }
	}
}