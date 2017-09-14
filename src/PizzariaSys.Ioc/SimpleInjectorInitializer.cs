﻿using Microsoft.Owin;
using PizzariaSys.Ioc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebActivatorEx;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer),"Initialize")]
namespace PizzariaSys.Ioc
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            //container.RegisterPerWebRequest(() =>
            //{
            //    if (HttpContext.Current != null && HttpContext.Current.Items["owin.Enviroment"] == null && container.IsVerifying)
            //    {
            //        return new OwinContext().Authentication;
            //    }

            //    return HttpContext.Current.GetOwinContext().Authentication;
            //});

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}
