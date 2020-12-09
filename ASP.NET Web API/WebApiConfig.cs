using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication2_WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes

            //enable attribute routing
            config.MapHttpAttributeRoutes();

            //custom route - work in postman , this route will be matched first (first come first serve)
            config.Routes.MapHttpRoute(
                name: "emp",
                routeTemplate: "api/emp",
                defaults: new { controller="employee" }
            );

            //add default route using convention-based routing
            //priority will be given to attribute routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}"
            );

        }
    }
}
