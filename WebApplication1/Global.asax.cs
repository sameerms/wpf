using NSwag.AspNet.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplication1
{
    ///<Summary>
    /// Gets the answer
    ///</Summary>
    public class WebApiApplication : System.Web.HttpApplication
    {

        ///<Summary>
        /// Gets the answer
        ///</Summary>
        protected void Application_Start()

        {
            RouteTable.Routes.MapOwinPath("swagger", app =>
            {
                app.UseSwaggerUi3(typeof(WebApiApplication).Assembly, settings =>
                {
                    settings.MiddlewareBasePath = "/swagger";
                    //settings.GeneratorSettings.DefaultUrlTemplate = "api/{controller}/{id}";  //this is the default one
                    settings.GeneratorSettings.DefaultUrlTemplate = "api/{controller}/{id}";
                });
            });
            GlobalConfiguration.Configure(WebApiConfig.Register);
            
        }
    }
}
