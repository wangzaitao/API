using LTHW.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LTHW.Weixin.Framework
{
    public class EWmaHandler
    {
        /// <summary>
        /// 通过Token获取二维码图片地址，加入openID参数
        /// </summary>
        /// <param name="formParam">formParam</param>
        /// <returns></returns>
        private static JObject CreateEWma(string formParam)
        {
            JObject resObj = null;
            try
            {
                var access_token = AccessTokenHandler.ManageAccessToken();
                var url = string.Format(WXUrlConfig.EWma_Url, access_token);

                LogHelper.Info(typeof(EWmaHandler), "获取二维码,url:" + url);
                var jsonText = HttpHandler.PostUrl(url, formParam);
                LogHelper.Info(typeof(EWmaHandler), "获取二维码,result:" + jsonText);

                var jsonObj = JObject.Parse(jsonText);
                if (jsonObj["errcode"] != null)
                {
                    LogHelper.Info(typeof(EWmaHandler), "获取二维码发生返回错误:" + jsonObj["errmsg"].ToString());
                }
                else
                {
                    resObj = jsonObj;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(UserHandler), "获取二维码出错：" + ex.Message + ex.InnerException.Message);
            }
            return resObj;
        }

        /// <summary>
        /// 临时
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetTmpEWmaImgUrlByopenID(int id)
        {
            string jsonParam = JsonConvert.SerializeObject(new { expire_seconds = 604800, action_name = "QR_SCENE", action_info = new { scene = new { scene_id = id } } });
            var jsonObj = CreateEWma(jsonParam);
            return string.Format(WXUrlConfig.EWma_Image_Url, HttpUtility.UrlEncode(jsonObj["ticket"].ToString()));
        }

        /// <summary>
        /// 永久
        /// </summary>
        /// <param name="openID"></param>
        /// <returns></returns>
        public static string GetForeverEWmaImgUrlByopenID(string openID)
        {
            string jsonParam = JsonConvert.SerializeObject(new { action_name = "QR_LIMIT_STR_SCENE", action_info = new { scene = new { scene_str = openID } } });
            var jsonObj = CreateEWma(jsonParam);
            return string.Format(WXUrlConfig.EWma_Image_Url, HttpUtility.UrlEncode(jsonObj["ticket"].ToString()));
        }
    }
}
