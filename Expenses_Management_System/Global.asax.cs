<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
=======
﻿using Expenses_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
>>>>>>> 2d83cd4 (Add project files.)
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
<<<<<<< HEAD
=======
using Unity;
using Unity.Mvc5;
>>>>>>> 2d83cd4 (Add project files.)

namespace Expenses_Management_System
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
<<<<<<< HEAD
=======

            // Register the service with Dependency Injection
            DependencyResolver.SetResolver(new UnityDependencyResolver(CreateUnityContainer()));
        }
        private static IUnityContainer CreateUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<MenuService>();
            return container;
>>>>>>> 2d83cd4 (Add project files.)
        }
    }
}
