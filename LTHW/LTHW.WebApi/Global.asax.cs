﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LTHW.Utility;

namespace LTHW.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //注册Cors跨域请求
            //GlobalConfiguration.Configuration.MessageHandlers.Add(new CorsHandler());

            //异常处理
            GlobalConfiguration.Configuration.Filters.Add(new WebApiExceptionFilterAttribute());

            //Ioc
            AutofacConfig.RegisterAutofac();
        }
    }
}
    