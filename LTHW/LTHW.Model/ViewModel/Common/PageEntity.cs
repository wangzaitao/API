using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    public class PageEntity<T>
    {
        /// <summary>
        /// 数据列表
        /// </summary>
        public T data { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int total { get; set; }
    }
}
