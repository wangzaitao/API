using LTHW.Utility;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    public class UserHandler
    {
        /// <summary>
        /// 通过OpenID来获取用户基本信息
        /// </summary>
        /// <param name="openID">openID</param>
        /// <returns></returns>
        public static WXUserInfo GetUserInfoByopenID(string openID)
        {
            WXUserInfo userInfo = null;
            try
            {
                var access_token = AccessTokenHandler.ManageAccessToken();
                var url = string.Format(WXUrlConfig.UserInfo_Url, access_token, openID);
                LogHelper.Info(typeof(UserHandler), "获取用户基本信息,url:" + url);
                var jsonText = HttpHandler.GetUrl(url);
                LogHelper.Info(typeof(UserHandler), "获取用户基本信息,userinfo:" + jsonText);

                var jsonUser = JObject.Parse(jsonText);
                if (jsonUser["errcode"] != null)
                {
                    LogHelper.Info(typeof(UserHandler), "获取用户基本信息发生返回错误:" + jsonUser["errmsg"].ToString());
                }
                else
                {
                    userInfo = new WXUserInfo
                    {
                        subscribe = jsonUser.Value<int>("subscribe"),
                        nickname = jsonUser.Value<string>("nickname"),
                        headimgurl = jsonUser.Value<string>("headimgurl"),
                        openid = jsonUser.Value<string>("openid"),
                        city = jsonUser.Value<string>("city"),
                        country = jsonUser.Value<string>("country"),
                        province = jsonUser.Value<string>("province"),
                        language = jsonUser.Value<string>("language"),
                        unionid = jsonUser.Value<string>("unionid"),
                        remark = jsonUser.Value<string>("remark"),
                        sex = jsonUser.Value<int>("sex"),
                        groupid = jsonUser.Value<int>("groupid"),
                        tagid_list = null,
                        subscribe_time = jsonUser.Value<int>("subscribe_time").ToDateTime(),
                    };
                    var tagidJArray = JArray.Parse(jsonUser["tagid_list"].ToString());
                    userInfo.tagid_list = new int[tagidJArray.Count];
                    for (var i = 0; i < tagidJArray.Count; i++)
                    {
                        userInfo.tagid_list[i] = (int)tagidJArray[i];
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(UserHandler), "通过OpenID来获取用户基本信息出错：" + ex.Message + ex.InnerException.Message);
            }
            return userInfo;
        }
    }
}
