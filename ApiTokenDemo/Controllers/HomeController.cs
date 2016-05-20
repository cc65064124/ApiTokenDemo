using BaseBLL;
using ClsBsaic.LibSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiTokenDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            testdemo();
            GetData();
            return View();
        }

        public void testdemo()
        {
            var ss = CreateRandomNum.CraetToken();

        }
        public  void GetData()
        {
            var userBLL = new UserBLL();
            var data = userBLL.GetBG_UserDataByPK("1");
        }
    }
}
