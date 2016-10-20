using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace LTHW.WebApi
{
    public class CorsHandler : DelegatingHandler
    {
        //CorsHandlder 实现跨域请求
        const string Origin = "*";  //配置允许请求地址
        const string AccessControlRequestMethod = "Access-Control-Request-Method";
        const string AccessControlRequestHeaders = "Access-Control-Request-Headers";
        const string AccessControlAllowOrigin = "Access-Control-Allow-Origin";
        const string AccessControlAllowMethods = "Access-Control-Allow-Methods";
        const string AccessControlAllowHeaders = "Access-Control-Allow-Headers";
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            bool isCorsRequest = request.Headers.Contains("Origin");
            bool isPreflightRequest = request.Method == HttpMethod.Options;
            if (isCorsRequest)
            {
                if (isPreflightRequest)
                {
                    return Task.Factory.StartNew<HttpResponseMessage>(() =>
                    {
                        HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                        //response.Headers.Add(AccessControlAllowOrigin, request.Headers.GetValues(Origin).First());
                        response.Headers.Add(AccessControlAllowOrigin, Origin);
                        string accessControlRequestMethod = request.Headers.GetValues(AccessControlRequestMethod).FirstOrDefault();
                        if (accessControlRequestMethod != null)
                        {
                            response.Headers.Add(AccessControlAllowMethods, accessControlRequestMethod);
                        }
                        string requestedHeaders = string.Join(", ", request.Headers.GetValues(AccessControlRequestHeaders));
                        if (!string.IsNullOrEmpty(requestedHeaders))
                        {
                            response.Headers.Add(AccessControlAllowHeaders, requestedHeaders);
                        }
                        return response;
                    },

                    cancellationToken);
                }
                else
                {
                    request.Properties.Add("LogTime", DateTime.Now);
                    return base.SendAsync(request, cancellationToken).ContinueWith<HttpResponseMessage>(t =>
                    {
                        HttpResponseMessage resp = t.Result;

                        DateTime LogTimeT = Convert.ToDateTime(resp.RequestMessage.Properties["LogTime"]);
                        DateTime LogTimeE = DateTime.Now;
                        TimeSpan ts = LogTimeT.Subtract(LogTimeE);
                        //LogHelper.Logger(log4net.LogManager.GetLogger(typeof(CorsHandler)), "请求路径:" + resp.RequestMessage.RequestUri.ToString());
                        //LogHelper.Logger(log4net.LogManager.GetLogger(typeof(CorsHandler)), "请求耗时:" + ts.TotalSeconds);


                        //resp.Headers.Add(AccessControlAllowOrigin, request.Headers.GetValues(Origin).First()); 
                        resp.Headers.Add(AccessControlAllowOrigin, Origin);
                        return resp;
                    });
                }
            }
            else
            {
                return base.SendAsync(request, cancellationToken);
            }
        }
    }
}