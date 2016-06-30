using System;

namespace LTHW.Utility
{
    /// <summary>
    /// 字符串扩展类
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 返回web引用路径格式
        /// </summary>
        /// <returns></returns>
        public static string ToWebPath(this string path)
        {
            return path.Replace("\\", "/");
        }

        /// <summary>
        /// 转成int型
        /// </summary>
        /// <returns></returns>
        public static int ToInt(this string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }
    }
}
