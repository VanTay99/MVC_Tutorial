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
               url: "product/{url}-{id}",
               defaults: new { controller = "Detail", action = "ViewDetail" }

               );
            routes.MapRoute(
               name: "Search",
               url: "search",
               defaults: new { Controller = "Search", action = "SearchByName" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeShop", action = "ViewProduct", id = UrlParameter.Optional }
                );

            routes.MapRoute(
               name: "NotFoundError",
               url: "{*url}",
               defaults: new { Controller = "Error", action = "PageNotFound" });

        }
    }
}