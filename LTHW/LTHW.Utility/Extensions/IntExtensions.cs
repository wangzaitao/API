using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Utility
{
    public static class IntExtensions
    {
        /// <summary>
        /// 转成date型
        /// </summary>
        /// <returns></returns>
        public static DateTime ToDateTime(this int value)
        {
            try
            {
                return new DateTime(value);
            }
            catch
            {
                return DateTime.Now;
            }
        }
    }
}
