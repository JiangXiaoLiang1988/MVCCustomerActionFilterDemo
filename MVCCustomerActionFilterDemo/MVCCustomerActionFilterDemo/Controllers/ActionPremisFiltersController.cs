using MVCCustomerActionFilterDemo.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCustomerActionFilterDemo.Controllers
{
    public class ActionPremisFiltersController : Controller
    {
        // GET: ActionPremisFilters
        [CustomerActionPremisFilters]
        public ActionResult Index()
        {
            return View();
        }
    }
}