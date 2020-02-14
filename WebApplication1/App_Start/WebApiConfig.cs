using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApplication1
{
    ///<Summary>
    /// Gets the answer
    ///</Summary>
    public static class WebApiConfig
  
    {
        ///<Summary>
        /// Gets the answer
        ///</Summary>
        public static void Register(HttpConfiguration config)
       
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
