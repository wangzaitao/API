using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [NotMapped]
    public class UserInfoEntity: sline_member
    {
        /// <summary>
        /// 微信openid
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string wxfrom { get; set; }

        /// <summary>
        /// 微信昵称
        /// </summary>
        public string wxnickname { get; set; }
    }
}
