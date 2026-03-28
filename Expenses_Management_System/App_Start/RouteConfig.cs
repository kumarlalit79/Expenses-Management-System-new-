using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Expenses_Management_System
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Signin", action = "Index", id = UrlParameter.Optional }
>>>>>>> 2d83cd4 (Add project files.)
            );
        }
    }
}
