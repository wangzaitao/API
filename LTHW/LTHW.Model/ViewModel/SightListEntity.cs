using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 景点列表实体
    /// </summary>
    public class SightListEntity
    {
        /// <summary>
        /// 门票id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 景点id
        /// </summary>
        public long? spotid { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public string sellprice { get; set; }

        /// <summary>
        /// 优惠价
        /// </summary>
        public string ourprice { get; set; }

        /// <summary>
        /// 图片列表
        /// </summary>
        public string piclist { get; set; }

        /// <summary>
        /// 属性分类id
        /// </summary>
        public string attrid { get; set; }

        /// <summary>
        /// 景点名称
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 景点简称
        /// </summary>
        public string shortname { get; set; }

        /// <summary>
        /// 满意次数
        /// </summary>
        public string satisfyscore { get; set; }

        /// <summary>
        /// 推荐次数
        /// </summary>
        public int? recommendnum { get; set; }

        /// <summary>
        /// 预定次数
        /// </summary>
        public string bookcount { get; set; }

        /// <summary>
        /// 取票方式
        /// </summary>
        public string getway { get; set; }

        /// <summary>
        /// 景点卖点
        /// </summary>
        public string sellpoint { get; set; }

        /// <summary>
        /// 友情提示
        /// </summary>
        public string friendtip { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public long? modtime { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double? lng { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double? lat { get; set; }

        /// <summary>
        /// 推荐
        /// </summary>
        public int? isjian { get; set; }

        /// <summary>
        /// 置顶
        /// </summary>
        public int? isding { get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        public string litpic { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public string kindlist { get; set; }
    }
}
