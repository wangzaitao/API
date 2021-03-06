﻿using LTHW.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    public class HttpHandler
    {
        public static string PostUrl(string url, string data)
        {
            try
            {
                LogHelper.Info(typeof(HttpHandler), "post url：" + url);
                var postBytes = Encoding.GetEncoding("utf-8").GetBytes(data);
                var myRequest = (HttpWebRequest)WebRequest.Create(url);
                myRequest.Method = "POST";
                myRequest.ContentType = "application/json";
                myRequest.ContentLength = postBytes.Length;
                myRequest.Proxy = null;
                var newStream = myRequest.GetRequestStream();
                newStream.Write(postBytes, 0, postBytes.Length);
                newStream.Close();
                var WebResp = (HttpWebResponse)myRequest.GetResponse();
                var Answer = new StreamReader(WebResp.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                var strResult = Answer.ReadToEnd();
                LogHelper.Info(typeof(HttpHandler), "推送消息返回的信息：" + strResult.ToString());
                
                return strResult;
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(HttpHandler), ex.Message);
                return "";
            }
        }

        public static string GetUrl(string url)
        {
            try
            {
                LogHelper.Info(typeof(HttpHandler), "get url：" + url);
                var myRequest = (HttpWebRequest)WebRequest.Create(url);
                myRequest.Method = "GET";
                myRequest.Proxy = null;
                var WebResp = (HttpWebResponse)myRequest.GetResponse();
                var Answer = new StreamReader(WebResp.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                var strResult = Answer.ReadToEnd();
                LogHelper.Info(typeof(HttpHandler), "推送消息返回的信息：" + strResult.ToString());

                return strResult;
            }
            catch (Exception ex)
            {
                LogHelper.Error(typeof(HttpHandler), ex.Message);
                return "";
            }
        }
    }
}
