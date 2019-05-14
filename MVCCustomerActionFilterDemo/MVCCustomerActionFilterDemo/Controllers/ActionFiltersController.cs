using MVCCustomerActionFilterDemo.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomerActionFilterDemo.Controllers
{
    public class ActionFiltersController : Controller
    {
        // GET: ActionFilters
        // [CustomerActionFilter]
        public ActionResult Index()
        {
            // Response.Write("<h2>执行Index...</h2>");
            return View();
        }
    }
}