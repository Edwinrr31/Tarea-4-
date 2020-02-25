using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tarea_4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Persona", action = "Index", id = UrlParameter.Optional }

                /*El parametro "URL" especifica el patron que debe de tener la URL en este caso espeficica
                 que controlador y que vista se invocaran en el caso de que el usuario no lo indique */
            );
        }
    }
}
