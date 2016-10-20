using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 线路分页查询条件
    /// </summary>
    public class TripQueryParam : PageQueryParam
    {
        /// <summary>
        /// 主题关键字
        /// </summary>       
        public string title { get; set; }
        /// <summary>
        /// 目的地
        /// </summary>
        public string kindlist { get; set; }
        /// <summary>
        /// 线路属性分类
        /// </summary>       
        public string attrid { get; set; }
        /// <summary>
        /// 价格排序
        /// </summary>
        public string orderprice { get; set; }
    }
}
