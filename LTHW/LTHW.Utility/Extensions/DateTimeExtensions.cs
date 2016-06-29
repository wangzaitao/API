using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Utility
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// 返回web引用路径格式
        /// </summary>
        /// <returns></returns>
        public static int ToInt(this DateTime dt)
        {
            var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            return (int)(dt - startTime).TotalSeconds;
        }
    }
}
