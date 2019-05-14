using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomerActionFilterDemo.Models
{
    //new RoleWithControllerAction(){ Id=1, ControllerName="AuthFilters", ActionName="AdminUser", RoleIds="1"},
    public class RoleWithControllerAction
    {
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string RoleIds { get; set; }
    }
}