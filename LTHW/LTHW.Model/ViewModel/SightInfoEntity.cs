using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 景点基本信息
    /// </summary>
    public class SightInfoEntity : SightListEntity
    {
        /// <summary>
        /// 出票方式(电子票、纸质票等)
        /// </summary>
        public string kindname { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        public int webid { get; set; }

        /// <summary>
        /// aid
        /// </summary>
        public long? aid { get; set; }

        /// <summary>
        /// 景点详情
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 预定须知
        /// </summary>
        public string booknotice { get; set; }

        /// <summary>
        /// 待定价格
        /// </summary>
        public int? price { get; set; }
    }
}
