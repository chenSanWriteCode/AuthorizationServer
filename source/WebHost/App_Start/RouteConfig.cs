﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Thinktecture.AuthorizationServer.WebHost
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "OAuth2 Authorize Endpoint",
                url: "oauth/{appName}/authorize",
                defaults: new
                {
                    controller = "Authorize",
                    action = "Index"
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}