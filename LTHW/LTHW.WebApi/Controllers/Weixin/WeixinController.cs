using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace LTHW.WebApi.Controllers.Weixin
{
    /// <summary>
    /// 微信接口
    /// </summary>
    [RoutePrefix("api/weixin")]
    public class WeixinController : ApiController
    {
        ///声明Token
        private string token = ConfigurationManager.AppSettings["WeixinToken"];

        /// <summary>
        /// 接入
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="echostr"></param>
        /// <returns></returns>
        public string get(string signature,string timestamp,string nonce,string echostr)
        {
            if (CheckSignature(signature, timestamp, nonce)) {
                return echostr;
            }
            return "";// _IHotelBLL.GetAll();
        }

        /// <summary>
        /// 验证微信签名
        /// </summary>
        /// * 将token、timestamp、nonce三个参数进行字典序排序
        /// * 将三个参数字符串拼接成一个字符串进行sha1加密
        /// * 开发者获得加密后的字符串可与signature对比，标识该请求来源于微信。
        /// <returns></returns>
        private bool CheckSignature(string signature, string timestamp, string nonce)
        {
            string[] ArrTmp = { token, timestamp, nonce };
            Array.Sort(ArrTmp); //字典排序
            string tmpStr = string.Join("", ArrTmp);
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            tmpStr = tmpStr.ToLower();
            if (tmpStr == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
