using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Security.Application;
using System.Web;

namespace ClsBsaic.Toolkit
{
   public  class ToolAntiXss
    {
        public void AntiXss()
        {
            string input = null;
            string strDecode = null;
            AntiXssEncoder a = new AntiXssEncoder();
            var html = Sanitizer.GetSafeHtml(input);
            var dd = Sanitizer.GetSafeHtmlFragment(input);
        }

        public string hmlDecode(string strDecode)
        {
            return HttpUtility.HtmlDecode(strDecode);
        }

        public string SafeHtml(string html)
        {
            return Sanitizer.GetSafeHtmlFragment(html);
        }
    }
}
