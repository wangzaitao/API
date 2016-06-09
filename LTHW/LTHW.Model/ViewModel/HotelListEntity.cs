using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 酒店列表实体
    /// </summary>
    public class HotelListEntity
    {
        /// <summary>
        /// 酒店id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 酒店卖点
        /// </summary>
        public string sellpoint { get; set; }

        /// <summary>
        /// 星级
        /// </summary>
        public int? hotelrankid { get; set; }
        /// <summary>
        /// 推荐
        /// </summary>
        public long? isjian { get; set; }

        /// <summary>
        /// 置顶
        /// </summary>
        public string isding { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public string lng { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public string lat { get; set; }

        /// <summary>
        /// 属性分类
        /// </summary>
        public string attrid { get; set; }

        /// <summary>
        /// 满意度
        /// </summary>
        public string satisfyscore { get; set; }

        /// <summary>
        /// 预定次数
        /// </summary>
        public string bookcount { get; set; }

        /// <summary>
        /// 推荐次数
        /// </summary>
        public int? recommendnum { get; set; }

        /// <summary>
        /// 开业时间
        /// </summary>
        public string opentime { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string telephone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 装修时间
        /// </summary>
        public string decoratetime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public long? modtime { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string litpic { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        public string piclist { get; set; }

        /// <summary>
        /// 待定价格
        /// </summary>
        public int? price { get; set; }

        /// <summary>
        /// 目的地列表
        /// </summary>
        public string kindlist { get; set; }
    }
}
