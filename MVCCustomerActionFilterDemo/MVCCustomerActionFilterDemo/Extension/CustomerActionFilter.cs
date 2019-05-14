using MVCCustomerActionFilterDemo.Models;
using MVCCustomerActionFilterDemo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomerActionFilterDemo.Extension
{
    //public class CustomerActionFilter : ActionFilterAttribute
    //{
    //    public override void OnActionExecuting(ActionExecutingContext filterContext)
    //    {
    //        filterContext.HttpContext.Response.Write("Action方法准备执行");
    //        string strControllerName = filterContext.RouteData.Values["controller"].ToString();
    //        string strActionName = filterContext.RouteData.Values["action"].ToString();
    //        LogEntity entity = new LogEntity()
    //        {
    //            OperationTime = DateTime.Now,
    //            ControllerName = strControllerName,
    //            ActionName = strActionName,
    //            // 为了方便测试写admin，真实案例需要获取当前登录的用户
    //            OperationUserId = "admin"
    //        };
    //        // 记录操作记录
    //        LogHelper.WriteOperRecore(entity);
    //        base.OnActionExecuting(filterContext);
    //    }

    //    public override void OnActionExecuted(ActionExecutedContext filterContext)
    //    {
    //        filterContext.HttpContext.Response.Write("Action方法执行结束");
    //        base.OnActionExecuted(filterContext);
    //    }


    //    public override void OnResultExecuting(ResultExecutingContext filterContext)
    //    {
    //        filterContext.HttpContext.Response.Write("Action方法执行结束，准备呈现视图");
    //        base.OnResultExecuting(filterContext);
    //    }

    //    public override void OnResultExecuted(ResultExecutedContext filterContext)
    //    {
    //        filterContext.HttpContext.Response.Write("视图呈现结束");
    //        base.OnResultExecuted(filterContext);
    //    }
    //}
}