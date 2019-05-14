using MVCCustomerActionFilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCCustomerActionFilterDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 显示登录视图
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOn()
        {
            LogOnViewModel model = new LogOnViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult LogOn(LogOnViewModel model)
        {
            //只要输入的用户名和密码一样就过
            if (model.UserName.Trim() == model.Password.Trim())
            {
                if (model.RememberMe)
                    FormsAuthentication.SetAuthCookie(model.UserName, true);   //2880分钟有效期的cookie
                else
                    FormsAuthentication.SetAuthCookie(model.UserName, false);  //会话cookie
                return RedirectToAction("Index", "ActionPremisFilters");
            }
            else
                return View(model);
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("LogOn");
        }
    }
}