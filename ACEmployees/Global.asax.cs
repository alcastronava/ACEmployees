using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ACEmployees.ModelBinders;

namespace ACEmployees
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var binder = new DateTimeModelBinder();
            System.Web.Mvc.ModelBinders.Binders.Add(typeof(DateTime), binder);
            System.Web.Mvc.ModelBinders.Binders.Add(typeof(DateTime?), binder);

            System.Web.Mvc.ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
        }
    }
}
