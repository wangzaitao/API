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

            builder.Register(c => new S_FriendLinkBLL()).As<IS_FriendLinkBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_TypeBLL()).As<IP_TypeBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_ProvinceBLL()).As<IS_ProvinceBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_CityBLL()).As<IS_CityBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_DistrictBLL()).As<IS_DistrictBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_NoticeBLL()).As<IS_NoticeBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_FriendLinkBLL()).As<IS_FriendLinkBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_AdminBLL()).As<IS_AdminBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_EmployeeBLL()).As<IS_EmployeeBLL>().InstancePerLifetimeScope();
            builder.Register(c => new S_FXCommisionBLL()).As<IS_FXCommisionBLL>().InstancePerLifetimeScope();
            builder.Register(c => new U_UserRegBLL()).As<IU_UserRegBLL>().InstancePerLifetimeScope();
            builder.Register(c => new U_UserInfoBLL()).As<IU_UserInfoBLL>().InstancePerLifetimeScope();
            builder.Register(c => new U_UserAccountBLL()).As<IU_UserAccountBLL>().InstancePerLifetimeScope();
            builder.Register(c => new U_UserAddressBLL()).As<IU_UserAddressBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_OrderBLL()).As<IUP_OrderBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_OrderDetailBLL()).As<IUP_OrderDetailBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_CartBLL()).As<IUP_CartBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_UserConsumeBLL()).As<IUP_UserConsumeBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_UserCommentBLL()).As<IUP_UserCommentBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_CommentImageBLL()).As<IUP_CommentImageBLL>().InstancePerLifetimeScope();
            builder.Register(c => new UP_CommentReplyBLL()).As<IUP_CommentReplyBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_TypeBLL()).As<IP_TypeBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_TypeCategoryBLL()).As<IP_TypeCategoryBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_CategoryBLL()).As<IP_CategoryBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_CategoryBrandBLL()).As<IP_CategoryBrandBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_BrandBLL()).As<IP_BrandBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_CategoryParamGroupBLL()).As<IP_CategoryParamGroupBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_ParamGroupBLL()).As<IP_ParamGroupBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_ParamBLL()).As<IP_ParamBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_CategoryProductBLL()).As<IP_CategoryProductBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_ProductBLL()).As<IP_ProductBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_PdtInfoBLL()).As<IP_PdtInfoBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_PriceBLL()).As<IP_PriceBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_PictureBLL()).As<IP_PictureBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_RouteBLL()).As<IP_RouteBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_PdtParamBLL()).As<IP_PdtParamBLL>().InstancePerLifetimeScope();
            builder.Register(c => new P_PdtKeywordBLL()).As<IP_PdtKeywordBLL>().InstancePerLifetimeScope();

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
