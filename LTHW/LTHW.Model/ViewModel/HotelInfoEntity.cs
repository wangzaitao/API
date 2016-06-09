using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 酒店基本信息
    /// </summary>
    public class HotelInfoEntity: HotelListEntity
    {

        /// <summary>
        /// 站点id
        /// </summary>
        public int webid { get; set; }

        /// <summary>
        /// aid
        /// </summary>
        public long? aid { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        public string fuwu { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public List<sline_destinations> MudidiList;
        /// <summary>
        /// 房间
        /// </summary>
        public List<sline_hotel_room> RoomList;

        /// <summary>
        /// 属性分类列表
        /// </summary>
        public List<sline_hotel_attr> AttrList;

        /// <summary>
        /// 描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 主级别
        /// </summary>
        public string mainrankid { get; set; }

        /// <summary>
        /// 交通方式
        /// </summary>
        public string traffic { get; set; }

        /// <summary>
        /// 周边景点
        /// </summary>
        public string aroundspots { get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        public string notice { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        public string equipment { get; set; }
    }
}
