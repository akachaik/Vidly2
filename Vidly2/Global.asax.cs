using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Vidly2.Models;
using Vidly2.Dtos;

namespace Vidly2
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Customer, CustomerDto>();
                config.CreateMap<CustomerDto, Customer>();
                config.CreateMap<Movie, MovieDto>();
                config.CreateMap<MovieDto, Movie>();
            });
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
