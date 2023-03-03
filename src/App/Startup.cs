using System.Web.Http;
using Microsoft.Owin.Diagnostics;
using Owin;

namespace App
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var errorOptions = new ErrorPageOptions
            {
                ShowExceptionDetails = true
            };

            appBuilder.UseErrorPage(errorOptions);
            appBuilder.UseWelcomePage("/api/welcome.html");

            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}