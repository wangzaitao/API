using LTHW.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    public class AccessTokenHandler
    {
        /// <summary>
        /// 获取基础Access_Token
        /// </summary>
        /// <returns></returns>
        private static string GetAccessToken()
        {
            string accessToken = null;
            try
            {
                var jsonText = HttpHandler.GetUrl(string.Format(WXUrlConfig.AccessToken_Url, BaseConfigurationManager.GetAppSettingsKeyValue("AppID"), BaseConfigurationManager.GetAppSettingsKeyValue("AppSecret")));
                LogHelper.Info(typeof(AccessTokenHandler), "获取基础Access_Token:" + jsonText);
                var jsonObject = JObject.Parse(jsonText);
                if (jsonObject["errcode"] != null)
                {
                    LogHelper.Info(typeof(AccessTokenHandler), "获取基础Access_Token发生返回错误:" + jsonObject["errmsg"].ToString());
                }
                else
                {
                    accessToken = jsonObject["access_token"].ToString();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(AccessTokenHandler), "获取基础Access_Token发生代码错误！" + ex.Message);
            }
            return accessToken;
        }

        /// <summary>
        /// 管理accesstoken
        /// </summary>
        /// <returns></returns>
        public static string ManageAccessToken()
        {
            return MemoryCacheHelper.GetCacheItem<string>("ACCESSTOKEN", () => { return GetAccessToken(); }, new TimeSpan(0, 100, 0));
        }
    }
}
