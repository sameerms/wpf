using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;


namespace WebApplication1.App_Start
{
    public class AutofacConfig
    {
        public static IContainer RegisterAutofac()
        {
            var builder = new ContainerBuilder();

            AddMvcRegistrations(builder);
            AddRegisterations(builder);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return container;
        }

        private static void AddMvcRegistrations(ContainerBuilder builder)
        {
            //mvc
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            //web api
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterModule<AutofacWebTypesModule>();
        }

        private static void AddRegisterations(ContainerBuilder builder)
        {
            //builder.RegisterModule(new MyCustomerWebAutoFacModule());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiModelBinderProvider();
        }
    }
}