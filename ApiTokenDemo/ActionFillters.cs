using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace ApiTokenDemo
{
    public class ActionFillters : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //执行action后执行这个方法 比如做操作日志
            var getRequest = filterContext.HttpContext.Request;
            var hostName = getRequest.UserHostAddress;
            var useAgent = getRequest.UserAgent;
            var content = getRequest.RequestContext;
            var Referer = getRequest.UrlReferrer.OriginalString;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //执行action前执行这个方法,比如做身份验证

        }
    }
}