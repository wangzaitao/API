using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    public class TripQueryParam : PageQueryParam
    {
        /// <summary>
        /// 是否推荐
        /// </summary>
        public int? isjian { get; set; }
        /// <summary>
        /// 是否特价
        /// </summary>
        public int? istejia { get; set; }
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
