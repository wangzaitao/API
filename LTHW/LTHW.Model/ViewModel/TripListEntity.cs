using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 线路列表实体
    /// </summary>
    public class TripListEntity
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
        /// 是否推荐
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 目的地
        /// </summary>
        public string kindlist { get; set; }
        /// <summary>
        /// 属性分类
        /// </summary>
        public string attrid { get; set; }
        /// <summary>
        /// 天数
        /// </summary>
        public long? lineday { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int? storeprice { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string litpic { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public long? modtime { get; set; }
    }
}
