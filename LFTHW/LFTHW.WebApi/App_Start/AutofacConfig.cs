using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using LFTHW.BLL;
using LFTHW.IBLL;
using System;
using System.Linq;

namespace LFTHW.WebApi
{
    public static class AutofacConfig
    {
        public static void RegisterAutofac()
        {
            var configuration = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerDependency();

            //builder.Register(c => new S_FriendLinkBLL()).As<IS_FriendLinkBLL>().InstancePerLifetimeScope();

            var container = builder.Build();
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);



            ////1.0 构造一个容器创建者对象
            //var bulider = new ContainerBuilder();

            ////2.0 告诉bulider将来控制器类去哪些程序中扫描
            //Assembly controllerAss = Assembly.Load("crm.Site");
            //bulider.RegisterControllers(controllerAss);

            ////3.0 告诉bulider将itcast.crm18.Dal中的所有类创建其对象实例存储在autofac的内部
            ////以此类的接口形式进行存储
            //Assembly dalAss = Assembly.Load("crm.DAL");
            //bulider.RegisterTypes(dalAss.GetTypes()).AsImplementedInterfaces();

            ////4.0 告诉bulider将itcast.crm18.Services中的所有类创建其对象实例存储在autofac的内部
            ////以此类的接口形式进行存储
            //Assembly servicesAss = Assembly.Load("crm.BLL");
            //bulider.RegisterTypes(servicesAss.GetTypes()).AsImplementedInterfaces();

            ////5.0 创建一个autofac的正真容器
            //IContainer container = bulider.Build();
            ////aotufac容器有一个方法在后面验证登录取cookie对象用
            ////aotufac容器有意个方法Resolve（），只需要提供一个借口名称 就能以接口的形式返回实现了这个接口的子类对象
            ////IsysUserInfoBLL userinfo= container.Resolve<IsysUserInfoBLL>();
            ////5.01将容器存入缓存里 (全局缓存)方便后面取出来使用
            //CheckManager.SetData(Keys.Autofac, container);
            ////获取autofac容器对象
            //// CheckManager.GetData<IContainer>(Keys.Autofac);
            ////6.0 将container交给MVC底层调用替换DefaultControllerFactory进行工作
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
