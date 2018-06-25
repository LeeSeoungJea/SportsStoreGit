﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: null,
                url: "",
                defaults: new { Controller = "Product", Action = "List", Category = (string)null, page=1 }
            );

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { Controller = "Product", Action = "List", Category = (string)null }
            );

            routes.MapRoute(
                name:null,
                url:"{category}",
                defaults: new { Controller = "Product" , Action = "List" , page = 1 }
            );

            routes.MapRoute(
                name: null,
                url: "{category}/Page{page}",
                defaults: new { Controller = "Product", Action = "List" },
                constraints: new { page=@"\d+" }
            );

            routes.MapRoute(
                name:null,
                url: "{controller}/{action}"
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            //);
        }
    }
}
