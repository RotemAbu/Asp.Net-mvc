﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HW1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

              routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UserLogin", action = "Index", id = UrlParameter.Optional }
            );

             // routes.MapRoute(
             //  name: "DefaultPage",
             //  url: "",
             //  defaults: new { controller = "Manager", action = "ManagerPage", id = UrlParameter.Optional }
             //);
         
        }
    }
}