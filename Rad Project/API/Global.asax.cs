using API.Models;
using API.Models.Scores;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            Database.SetInitializer(new ApplicationDBInitializer());
            ApplicationDbContext db = new ApplicationDbContext();
            db.Database.Initialize(true);

            Database.SetInitializer(new ScoresDbInitializer());
            ScoresDbContext sp_db = new ScoresDbContext();
            sp_db.Database.Initialize(true);

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
