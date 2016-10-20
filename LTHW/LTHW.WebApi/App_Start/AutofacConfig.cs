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
            builder.Register(c => new HotelBLL()).As<IHotelBLL>().InstancePerLifetimeScope();
            builder.Register(c => new SightBLL()).As<ISightBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UserBLL()).As<IUserBLL>().InstancePerLifetimeScope();
            builder.Register(c => new RegionBLL()).As<IRegionBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UserAddressBLL()).As<IUserAddressBLL>().InstancePerLifetimeScope();
            builder.Register(c => new ArticleBLL()).As<IArticleBLL>().InstancePerLifetimeScope();
            builder.Register(c => new NotesBLL()).As<INotesBLL>().InstancePerLifetimeScope();

            var container = builder.Build();
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
