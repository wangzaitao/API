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

                var decodedJSON = JObject.Parse(jsonText);
                if (decodedJSON["errcode"] != null)
                {
                    LogHelper.Info(typeof(UserHandler), "获取Token发生返回错误:" + decodedJSON["errmsg"].ToString());
                }
                else
                {
                    userInfo = new WXUserInfo
                    {
                        subscribe = decodedJSON.Value<int>("subscribe"),
                        nickname = decodedJSON.Value<string>("nickname"),
                        headimgurl = decodedJSON.Value<string>("headimgurl"),
                        openid = decodedJSON.Value<string>("openid"),
                        city = decodedJSON.Value<string>("city"),
                        country = decodedJSON.Value<string>("country"),
                        province = decodedJSON.Value<string>("province"),
                        language = decodedJSON.Value<string>("language"),
                        unionid = decodedJSON.Value<string>("unionid"),
                        remark = decodedJSON.Value<string>("remark"),
                        sex = decodedJSON.Value<int>("sex"),
                        groupid = decodedJSON.Value<int>("groupid"),
                        tagid_list = decodedJSON.Value<int[]>("tagid_list"),
                        subscribe_time = decodedJSON.Value<int>("subscribe_time").ToDateTime(),
                    };
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
