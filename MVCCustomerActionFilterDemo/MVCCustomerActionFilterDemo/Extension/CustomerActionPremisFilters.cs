using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCustomerActionFilterDemo.DataBase;
using MVCCustomerActionFilterDemo.Models;

namespace MVCCustomerActionFilterDemo.Extension
{
    public class CustomerActionPremisFilters :ActionFilterAttribute
    {
        public string ActionName { get; set; } //用于保存Action配置的别名
        public string AreaName { get; set; }
        public string Roles { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 如果未登录，则跳转到登录界面
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.HttpContext.Response.Redirect("/Account/LogOn");
                return;
            }
            //当前登录用户的用户名
            string userName = filterContext.HttpContext.User.Identity.Name;
            //当前登录用户对象
            User user = SampleData.users.Find(u => u.UserName == userName);  

            if (user != null)
            {
                //当前登录用户的角色
                Role role = SampleData.roles.Find(r => r.Id == user.RoleId); 

                //获得controller：
                string controllerName = filterContext.RouteData.Values["controller"].ToString().ToLower();
                if (ActionName == null)
                {
                    ActionName = filterContext.RouteData.Values["action"].ToString();
                }
                  

                //查询角色id
                RoleWithControllerAction roleWithControllerAction = SampleData.roleWithControllerAndAction.Find(r => r.ControllerName.ToLower() == controllerName && ActionName.ToLower() == ActionName.ToLower());
                if (roleWithControllerAction != null)
                {
                    //有权限操作当前控制器和Action的角色id
                    this.Roles = roleWithControllerAction.RoleIds;    
                }
                if (!string.IsNullOrEmpty(Roles))
                {
                    foreach (string roleid in Roles.Split(','))
                    {
                        if (role.Id.ToString() == roleid)
                        {
                            //return就说明有权限了，后面的代码就不跑了，直接返回视图给浏览器就好
                            return;
                        }
                  
                    }
                }

                filterContext.Result = new ViewResult { ViewName = "Error", };
                return;
            }
            else
            {
                filterContext.Result = new EmptyResult();
                filterContext.HttpContext.Response.Redirect("/Account/Logon", true);
                return;

            }
        }
    }
}