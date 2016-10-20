using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 酒店查询参数
    /// </summary>
    public class HotelQueryParam : PageQueryParam
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
        /// 酒店名称关键字
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 价格排序
        /// </summary>
        public string orderprice { get; set; }
    }
}
