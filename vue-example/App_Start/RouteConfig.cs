﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace vue_example
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "Home" }
                );
            
            routes.MapRoute(
              name: "Silo Controller",
              url: "{controller}/{*.}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
              constraints: new { controller = "vuerouting|otherControllersCanGoHere" }
              );
        }
    }
}
