using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{

    /// <summary>
    /// 线路基本信息实体
    /// </summary>
    [NotMapped]
    public class TripInfoEntity
    {
        /// <summary>
        /// 线路基本信息
        /// </summary>
        public sline_line Info;
        /// <summary>
        /// 行程内容
        /// </summary>
        public List<sline_line_jieshao> ContentList;
        /// <summary>
        /// 目的地
        /// </summary>
        public List<sline_destinations> MudidiList;
        /// <summary>
        /// 线路属性方式
        /// </summary>
        public List<sline_line_attr> AttrList;
    }
}
