using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TeleMedicine_Api.BLL.BusinessServices;
using TeleMedicine_Api.BLL.Interfaces;
using TeleMedicine_Api.DAL.Interfaces;
using TeleMedicine_Api.DAL.Repositories;
using Unity;

namespace TeleMedicine_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //DOI Unity
            var container = new UnityContainer();
            //Register the interfaces here..
            //Register Business login interfaces here..

            container.RegisterType<IAuthenticateBS, AuthenticateBS>();
            container.RegisterType<IReceptionBS, ReceptionBS>();

            //Register Data access layer interfaces here..

            container.RegisterType<IAuthenticateRepository, AuthenticateRepository>();
            container.RegisterType<IReceptionRepository, ReceptionRepository>();

            //Utility dependency resolver here

            config.DependencyResolver = new UnityResolver(container);



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
