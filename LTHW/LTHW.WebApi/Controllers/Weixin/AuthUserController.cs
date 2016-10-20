using LTHW.Utility;
using LTHW.Weixin.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.Weixin
{
    /// <summary>
    /// 授权用户
    /// </summary>
    [RoutePrefix("api/weixin/auth")]
    public class AuthUserController : ApiController
    {
        /// <summary>
        /// 获取网页授权用户基本信息
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="appsecret"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        [Route("getuserinfo")]
        public string getUserInfo(string appid, string appsecret, string code)
        {
            try
            {
                LogHelper.Info(this, string.Format("appid:{0},appsecret:{1},code:{2}", appid, appsecret, code));
                return AuthUserHandler.GetAuthUserInfo(appid, appsecret, code);
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, "获取网页授权用户基本信息代码错误：" + ex.Message + ex.InnerException.Message);
            }
            return string.Empty;
        }
    }
}
