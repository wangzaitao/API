using LTHW.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Weixin.Framework
{
    /// <summary>
    /// 接入、签名操作
    /// </summary>
    public class SignatureHandler
    {
        #region 方法

        #region 检查加密签名是否一致 - public static bool CheckSignature(string signature, string timestamp, string nonce)

        /// <summary>
        /// 检查加密签名是否一致
        /// </summary>
        /// <param name="signature">微信加密签名</param>
        /// <param name="timestamp">时间戳</param>
        /// <param name="nonce">随机数</param>
        /// <returns></returns>
        public static bool CheckSignature(string token, string signature, string timestamp, string nonce)
        {
            var ArrTmp = new string[] { token, timestamp, nonce };
            var tmpStr = string.Join("", ArrTmp.OrderBy(m => m));
            var tmpSign = Sha1Encrypt(tmpStr);
            LogHelper.Info(typeof(SignatureHandler), string.Format("tmpSign:{0},signature:{1}", tmpSign, signature));
            return tmpSign == signature;
        }

        #endregion

        #region 对字符串SHA1加密 - public static string Sha1Encrypt(string targetString)

        /// <summary>
        /// 对字符串SHA1加密
        /// </summary>
        /// <param name="targetString">源字符串</param>
        /// <returns>加密后的十六进制字符串</returns>
        private static string Sha1Encrypt(string targetString)
        {
            byte[] byteArray = Encoding.Default.GetBytes(targetString);
            HashAlgorithm hashAlgorithm = new SHA1CryptoServiceProvider();
            byteArray = hashAlgorithm.ComputeHash(byteArray);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte item in byteArray)
            {
                stringBuilder.AppendFormat("{0:x2}", item);
            }
            return stringBuilder.ToString();
        }

        #endregion

        #region 根据加密类型对字符串SHA1加密 - public static string Sha1Encrypt(string targetString, string encryptType)

        /// <summary>
        /// 根据加密类型对字符串SHA1加密
        /// </summary>
        /// <param name="targetString">源字符串</param>
        /// <param name="encryptType">加密类型：MD5/SHA1</param>
        /// <returns>加密后的字符串</returns>
        private static string Sha1Encrypt(string targetString, string encryptType)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(targetString, encryptType);
        }

        #endregion

        #endregion
    }
}
