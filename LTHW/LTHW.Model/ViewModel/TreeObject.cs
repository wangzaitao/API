using System.Collections.Generic;

namespace LTHW.Model
{
    /// <summary>
    /// 树对象
    /// </summary>
    public class TreeObject
    {
        /// <summary>
        /// id
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// 父id
        /// </summary>
        public int? pid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 子节点
        /// </summary>
        public List<TreeObject> nodes { get; set; }
        /// <summary>
        /// 标识
        /// </summary>
        public string flag { get; set; }
    }
}
