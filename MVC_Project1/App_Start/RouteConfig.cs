using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Project1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dammio", action = "Product", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Chi tiet San Pham",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Productdetail", action = "Productdetail", id = UrlParameter.Optional }
           );
            

        }
    }
}
