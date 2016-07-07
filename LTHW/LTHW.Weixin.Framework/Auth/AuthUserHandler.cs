using LTHW.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    public class AuthUserHandler
    {
        /// <summary>
        /// 获取网页授权用户基本信息
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="appsecret"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetAuthUserInfo(string appid, string appsecret, string code)
        {
            try
            {
                var access_token_Object = AuthAccessTokenHandler.GetAuthAccessToken(appid, appsecret, code);
                if (access_token_Object != null)
                {
                    var access_token = string.Empty;
                    var openid = string.Empty;
                    var refresh_access_token = string.Empty;
                    if (access_token_Object["errcode"] != null)
                    {
                        LogHelper.Info(typeof(AccessTokenHandler), "获取网页授权Access_Token发生返回错误:" + access_token_Object["errmsg"].ToString());
                    }
                    else
                    {
                        openid = access_token_Object["openid"].ToString();
                        access_token = access_token_Object["access_token"].ToString();
                        refresh_access_token = access_token_Object["refresh_token"].ToString();
                    }

                    if (!string.IsNullOrEmpty(access_token))
                    {
                        var url = string.Format(WXUrlConfig.Auth_UserInfo_Url, access_token, openid);
                        LogHelper.Info(typeof(UserHandler), "获取网页授权用户基本信息,url:" + url);
                        var jsonText = HttpHandler.GetUrl(url);
                        LogHelper.Info(typeof(UserHandler), "获取网页授权用户基本信息,userinfo:" + jsonText);

                        var jsonUser = JObject.Parse(jsonText);
                        if (jsonUser["errcode"] != null)
                        {//刷新一次access_token
                            LogHelper.Info(typeof(UserHandler), "获取网页授权用户发生返回错误:" + jsonUser["errmsg"].ToString());
                            access_token_Object = AuthAccessTokenHandler.RefreshAuthAccessToken(appid, refresh_access_token);
                            LogHelper.Info(typeof(UserHandler), "刷新access_token");

                            if (access_token_Object["errcode"] != null)
                            {
                                LogHelper.Info(typeof(AccessTokenHandler), "获取网页授权Access_Token发生返回错误:" + access_token_Object["errmsg"].ToString());
                            }
                            else
                            {
                                openid = access_token_Object["openid"].ToString();
                                access_token = access_token_Object["access_token"].ToString();
                                refresh_access_token = access_token_Object["refresh_token"].ToString();
                            }

                            if (!string.IsNullOrEmpty(access_token))
                            {
                                var _url = string.Format(WXUrlConfig.Auth_UserInfo_Url, access_token, openid);
                                LogHelper.Info(typeof(UserHandler), "获取网页授权用户基本信息,url:" + _url);
                                var _jsonText = HttpHandler.GetUrl(_url);
                                LogHelper.Info(typeof(UserHandler), "获取网页授权用户基本信息,userinfo:" + _jsonText);
                            }
                        }

                        return jsonText;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(UserHandler), "获取网页授权用户基本信息出错：" + ex.Message + ex.InnerException.Message);
            }
            return string.Empty;
        }
    }
}
