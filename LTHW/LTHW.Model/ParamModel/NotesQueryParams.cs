using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 游记
    /// </summary>
    public class NotesQueryParams : PageQueryParam
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public long memberid { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
    }
}
