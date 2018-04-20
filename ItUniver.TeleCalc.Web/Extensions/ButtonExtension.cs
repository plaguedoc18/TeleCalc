using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItUniver.TeleCalc.Web.Extensions
{
    public static class ButtonExtension
    {
        /// <summary>
        /// Сгенерировать кнопку для отправки формы с заданным именем
        /// </summary>
        /// <param name="Html"></param>
        /// <param name="name">Название кнопки</param>
        /// <returns>html-разметка</returns>
        public static MvcHtmlString Submit (this HtmlHelper Html, string name, string onclick)
        {
            
            
            var btn ="<input type=\"submit\" value=\""+name+"\" class=\"btn btn-default\" onclick=\""+onclick+"\" />";
            return new MvcHtmlString(btn);
        }
    }
}