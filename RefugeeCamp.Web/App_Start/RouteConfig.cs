using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RefugeeCamp.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Update",
            url: "{Teacher}/{Edit}/{id}",
            defaults: new { controller = "Teacher", action = "Edit", id = UrlParameter.Optional });
      
            routes.MapRoute(
              name: "Delete",
              url: "{Teacher}/{Delete}/{id}",
              defaults: new { controller = "Teacher", action = "Delete", id = UrlParameter.Optional });



            routes.MapRoute(
         name: "UpdateStudent",
         url: "{Level}/{Edit}/{id}",
         defaults: new { controller = "Level", action = "Edit", id = UrlParameter.Optional });

            routes.MapRoute(
              name: "DeleteStudent",
              url: "{Level}/{Delete}/{id}",
              defaults: new { controller = "Level", action = "Delete", id = UrlParameter.Optional });


            
        }
    }
    }

