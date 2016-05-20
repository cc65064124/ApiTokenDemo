using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiTokenDemo
{
    public class ResultFillters : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //执行完Result后跳转前执行
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //执行完Result后跳转后执行
        }
    }
}