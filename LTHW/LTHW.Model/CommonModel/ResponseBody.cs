using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 返回实体
    /// </summary>
    public class ResponseBody<T>
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public T Result { get; set; }
    }
}
