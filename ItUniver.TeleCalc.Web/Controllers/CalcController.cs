using ItUniver.TeleCalc.Core;
using ItUniver.TeleCalc.Web.Models;
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
        public ActionResult Exec()
        {
            var calc = new Calc();
            SelectList Slist = new SelectList(calc.GetOpers);
            ViewBag.list = Slist;
            return View();
        }
         [HttpPost]  
         public Double Exec(CalcModel model )
        {
            var calc = new Calc();
            var operName = calc.GetOpers;
            if (calc.GetOpers.Contains(model.Opername))
            {
               return calc.Exec(model.Opername.ToLower(), model.X, model.Y);
                
            }

            return double.NaN;
        }
    [HttpGet]
        public ActionResult Index(String operName, Double? x, Double? y)
        {
            var calc = new Calc();
            ViewBag.Error = null;

            if (calc.GetOpers.Contains(operName))
            {
                ViewBag.Result = calc.Exec(operName.ToLower(), x, y);
                ViewBag.OperName = operName;
                ViewBag.DataX = x;
                ViewBag.DataY = y;
            }
            else 
            { 
                ViewBag.Error = "Неверная команда";
            }
            return View();
        }

        public ActionResult Operations()
        {
            var calc = new Calc();
            var list = calc.GetOpers;            
            ViewBag.list = list;
            return View("Ops");
        }


	}

}