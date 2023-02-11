using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aula1AspNetMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Secundaria",
                url: "{controller}/{action}/{idCliente}/{nomeCliente}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    //id = UrlParameter.Optional,
                    //nome = UrlParameter.Optional 
                }
            );

            // Rota mais genérica fica no final
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
