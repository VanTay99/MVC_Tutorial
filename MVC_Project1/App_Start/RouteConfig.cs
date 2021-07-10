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
            routes.MapRoute(
               name: "ViewDetail",
               url: "san-pham-{lname}-{Id}",
               defaults: new { controller = "Detail", action = "ViewDeTail" }
               );
            routes.MapRoute(
               name: "ViewProduct",
               url: "product/viewproduct",
               defaults: new { controller = "HomeShop", action = "ViewProduct" }
               );
            routes.MapRoute(
                 name: "Default",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "HomeShop", action = "ViewProduct", id = UrlParameter.Optional }
                 );
        }
    }
}