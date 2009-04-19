using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MBlog.Web.Miscellaneous;
using StructureMap;
using MBlog.Data.DataAccess;
using MBlog.Service;

namespace MBlog.Web {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

        }

        protected void Application_Start() {
            RegisterRoutes(RouteTable.Routes);
            ConfigureStructureMap();
            ControllerBuilder.Current.SetControllerFactory(new IoCControllerFactory());
        }

        //TODO:Find a better place to wire up the IoC Container
        private void ConfigureStructureMap() {
            StructureMapConfiguration.ForRequestedType<IPostRepository>().TheDefaultIsConcreteType<PostRepository>();
            StructureMapConfiguration.ForRequestedType<IBlogService>().TheDefaultIsConcreteType<BlogService>();
        }
    }
}