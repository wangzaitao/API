using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using LTHW.BLL;
using LTHW.IBLL;
using System;
using System.Linq;
using LTHW.IBLL.Mysql;
using LTHW.BLL.Mysql;

namespace LTHW.WebApi
{
    public static class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var configuration = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerDependency();

            builder.Register(c => new TripsBLL()).As<ITripsBLL>().InstancePerLifetimeScope();
            builder.Register(c => new MuDiDiBLL()).As<IMuDiDiBLL>().InstancePerLifetimeScope();

            var container = builder.Build();
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
