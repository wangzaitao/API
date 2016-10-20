using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 文章
    /// </summary>
    public class ArticleQueryParam : PageQueryParam
    {
        /// <summary>
        /// 目的地id
        /// </summary>
        public string themelist { get; set; }

        /// <summary>
        /// 目的地id
        /// </summary>
        public string kindlist { get; set; }

        /// <summary>
        /// 属性分类id
        /// </summary>
        public string attrid { get; set; }

        /// <summary>
        /// 名称关键字
        /// </summary>
        public string title { get; set; }
    }
}
