using LTHW.IBLL.Mysql;
using LTHW.Model;
using LTHW.Utility;
using LTHW.Weixin.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Security;
using System.Xml;

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

        readonly IUserBLL _IUserBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iUserBLL"></param>
        public WeixinController(IUserBLL iUserBLL)
        {
            _IUserBLL = iUserBLL;
        }

        /// <summary>
        /// 接入
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="echostr"></param>
        /// <returns></returns>
        public HttpResponseMessage get(string signature, string timestamp, string nonce, string echostr)
        {
            try
            {
                LogHelper.Info(this, string.Format("signature:{0},timestamp:{1},nonce:{2},echostr:{3},token:{4}", signature, timestamp, nonce, echostr, token));
                if (SignatureHandler.CheckSignature(token, signature, timestamp, nonce))
                {
                    return ToHttpMsgForWeChat(echostr);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, "验证微信接口代码错误：" + ex.Message + ex.InnerException.Message);
            }
            return ToHttpMsgForWeChat("验证失败");
        }

        /// <summary>
        /// 测试用
        /// </summary>
        /// <returns></returns>
        [Route("gettest")]
        public int gettest()
        {
            var wxUser = UserHandler.GetUserInfoByopenID("oZ0NuwPJqqT77z68HmkVXjc1g5ns");
            var weixinModel = new WXUserInfoEntity
            {
                from = "wx",
                headimgurl = wxUser.headimgurl,
                status = 1,
                nickname = wxUser.nickname,
                openid = "oZ0NuwPJqqT77z68HmkVXjc1g5ns",
                pwd = "",
                recommendopenid = "",
                subscribetime = DateTime.Now
            };
            return _IUserBLL.EditWeixinUser(weixinModel);
        }

        /// <summary>
        /// 微信post
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <param name="echostr"></param>
        /// <returns></returns>
        public string post()
        {
            var retXML = string.Empty;
            var xmlDoc = new XmlDocument();
            try
            {
                var postStr = Request.Content.ReadAsStreamAsync().Result;                
                xmlDoc.Load(postStr);
                LogHelper.Info(this, "微信参数：" + xmlDoc.OuterXml);

                var msgType = ReadElementFromWXxml(xmlDoc, "MsgType");
                var toUserName = ReadElementFromWXxml(xmlDoc, "ToUserName");
                var fromUserName = ReadElementFromWXxml(xmlDoc, "FromUserName");

                switch (msgType.ToLower())
                {
                    case "event": //事件
                        //菜单KEY
                        var menuKey = ReadElementFromWXxml(xmlDoc, "EventKey");
                        var eventType = ReadElementFromWXxml(xmlDoc, "Event");
                        switch (eventType.ToLower())
                        {
                            case "subscribe":
                                //存入数据库
                                var wxUser = UserHandler.GetUserInfoByopenID(fromUserName);
                                var weixinModel = new WXUserInfoEntity
                                {
                                    from = "wx",
                                    headimgurl = wxUser.headimgurl,
                                    status = 1,
                                    nickname = wxUser.nickname,
                                    openid = fromUserName,
                                    pwd = "",
                                    recommendopenid = "",
                                    subscribetime = DateTime.Now
                                };
                                _IUserBLL.EditWeixinUser(weixinModel);
                                //推送消息
                                retXML = ReturnTextXML(toUserName, fromUserName, "欢迎关注公众号！");
                                break;
                            case "unsubscribe":
                                var un_weixinModel = new WXUserInfoEntity
                                {
                                    from = "wx",
                                    headimgurl = "",
                                    status = 0,
                                    nickname = "",
                                    openid = fromUserName,
                                    pwd = "",
                                    recommendopenid = "",
                                    unsubscribetime = DateTime.Now
                                };
                                _IUserBLL.EditWeixinUser(un_weixinModel);
                                //修改数据库
                                break;
                            case "click":
                                //修改数据库
                                break;
                            case "location":
                                //修改数据库
                                var latitude = xmlDoc.SelectSingleNode("/xml/Latitude");
                                var longitude = xmlDoc.SelectSingleNode("/xml/Longitude");
                                //var baiduLatLng = BaiDuGeoCoder.GetAddressByLocation(lat, lng);
                                //if (baiduLatLng != null && baiduLatLng.addressComponent != null)
                                //{
                                //    Session["currentCity"] = baiduLatLng.addressComponent.city;
                                //}
                                break;
                        }
                        break;
                }

                return retXML;
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, "微信api出现错误！" + ex.Message);
                return "";
            }

        }

        private string ReadElementFromWXxml(XmlDocument xmlDoc, string elementName)
        {
            var node = xmlDoc.SelectSingleNode("xml/" + elementName);
            //for (int i = 0; i < nodeList.Count; i++)
            //{
            //    if (nodeList[i].ChildNodes[0].NodeType == XmlNodeType.CDATA)
            //        res = nodeList[i].ChildNodes[0].Value;
            //}
            return node.InnerText;
        }

        /// <summary>
        /// 返回文本信息
        /// </summary>
        /// <param name="fromUserName">公众号id</param>
        /// <param name="toUserName">用户id</param>
        /// <param name="message">返回消息</param>
        /// <returns></returns>
        private string ReturnTextXML(string fromUserName, string toUserName, string message)
        {
            var sbRetXML = new StringBuilder();
            sbRetXML.Append("<xml>")
                .AppendFormat("<ToUserName><![CDATA[{0}]]></ToUserName>", toUserName)
                .AppendFormat("<FromUserName><![CDATA[{0}]]></FromUserName>", fromUserName)
                .AppendFormat("<CreateTime>{0}</CreateTime>", DateTime.Now.ToInt())
                .Append("<MsgType><![CDATA[text]]></MsgType>")
                .AppendFormat("<Content><![CDATA[{0}]]></Content>", message)
                .Append("</xml>");

            return sbRetXML.ToString();
        }

        private HttpResponseMessage ToHttpMsgForWeChat(string strMsg)
        {
            HttpResponseMessage result = new HttpResponseMessage
            {
                Content = new StringContent(strMsg, Encoding.GetEncoding("UTF-8"), "application/x-www-form-urlencoded")
            };
            return result;
        }
    }
}
