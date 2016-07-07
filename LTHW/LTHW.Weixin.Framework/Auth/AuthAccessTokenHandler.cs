using LTHW.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    public class AuthAccessTokenHandler
    {
        /// <summary>
        /// 获取网页授权的Access_Token
        /// </summary>
        /// <returns></returns>
        public static JObject GetAuthAccessToken(string appid, string appsecret, string code)
        {
            try
            {
                var jsonText = HttpHandler.GetUrl(string.Format(WXUrlConfig.Auth_AccessToken_Url, appid, appsecret, code));
                LogHelper.Info(typeof(AccessTokenHandler), "获取网页授权的Access_Token:" + jsonText);
                var jsonObject = JObject.Parse(jsonText);
                return jsonObject;
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(AccessTokenHandler), "获取网页授权的Access_Token发生代码错误！" + ex.Message);
            }
            return null;
        }

        /// <summary>
        /// 刷新网页授权的Access_Token
        /// </summary>
        /// <returns></returns>
        public static JObject RefreshAuthAccessToken(string appid, string refresh_Access_Token)
        {
            try
            {
                var jsonText = HttpHandler.GetUrl(string.Format(WXUrlConfig.Auth_Refresh_AccessToken_Url, appid, refresh_Access_Token));
                LogHelper.Info(typeof(AccessTokenHandler), "刷新网页授权的Access_Token:" + jsonText);
                var jsonObject = JObject.Parse(jsonText);
                return jsonObject;
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(AccessTokenHandler), "刷新网页授权的Access_Token发生代码错误！" + ex.Message);
            }
            return null;
        }
    }
}
