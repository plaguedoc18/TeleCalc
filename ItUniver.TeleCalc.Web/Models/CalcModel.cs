using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItUniver.TeleCalc.Web.Models
{
    public class CalcModel
    {
        public string Opername {get; set;}
        public double X {get; set;}
    [Required(ErrorMessage="Пропушено")]
        public double Y { get; set; }
    [ReadOnly(true)]
        public double Result { get; set; }

    }
}