using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ServiceHost
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        //private void RegisterRoutes()
        //{
        //    // Edit the base address of Service1 by replacing the "Service1" string below
        //    RouteTable.Routes.Add(new ServiceRoute("api/MH/role/", new WebServiceHostFactory(), typeof(MHRoleService)));
        //    RouteTable.Routes.Add(new ServiceRoute("api/MH/district/", new WebServiceHostFactory(), typeof(DistrictManageService)));
        //    RouteTable.Routes.Add(new ServiceRoute("api/Sys/notice/", new WebServiceHostFactory(), typeof(SysNoticeService)));
        //}
    }
}