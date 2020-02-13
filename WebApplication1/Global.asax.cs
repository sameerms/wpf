using NSwag.AspNet.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplication1
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'WebApiApplication'
    public class WebApiApplication : System.Web.HttpApplication
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'WebApiApplication'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'WebApiApplication.Application_Start()'
        protected void Application_Start()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'WebApiApplication.Application_Start()'
        {
            RouteTable.Routes.MapOwinPath("swagger", app =>
            {
                app.UseSwaggerUi3(typeof(WebApiApplication).Assembly, settings =>
                {
                    settings.MiddlewareBasePath = "/swagger";
                    //settings.GeneratorSettings.DefaultUrlTemplate = "api/{controller}/{id}";  //this is the default one
                    settings.GeneratorSettings.DefaultUrlTemplate = "api/{controller}/{action}/{id}";
                });
            });
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
