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

        private Calc Calc { get; set; }

        public CalcController()
        {
            var calc = new Calc();
        }
        [HttpGet]
        public ActionResult Exec()
        {
            var calc = new Calc();
            var model = new CalcModel();
            var list = new SelectList(calc.GetOperNames());
            model.OperationList = list;
            return View(model);
        }
         [HttpPost]  
         public PartialViewResult Exec(CalcModel model )
        {
            var calc = new Calc();
            var result = double.NaN;
            if (Calc.GetOperNames().Contains(model.Opername))
            {
               result =  calc.Exec(model.Opername.ToLower(), model.InputData);
                
            }

            return PartialView("_Result", result);
        }
    [HttpGet]
        public ActionResult Index(String operName, Double x, Double y)
        {
            var calc = new Calc();
            ViewBag.Error = null;

            if (Calc.GetOperNames().Contains(operName))
            {
                ViewBag.Result = calc.Exec(operName.ToLower(), new double[]{x, y});
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
            var list = Calc.GetOperNames();            
            ViewBag.list = list;
            return View();
        }


	}

}