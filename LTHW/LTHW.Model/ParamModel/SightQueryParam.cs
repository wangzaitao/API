using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 景点查询参数
    /// </summary>
    public class SightQueryParam : PageQueryParam
    {
        /// <summary>
        /// 目的地id
        /// </summary>
        public string kindlist { get; set; }
        /// <summary>
        /// 属性分类id
        /// </summary>
        public string attrid { get; set; }

        /// <summary>
        /// 景点名称关键字
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 价格排序
        /// </summary>
        public string orderprice { get; set; }
    }
}
