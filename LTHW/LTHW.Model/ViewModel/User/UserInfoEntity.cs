using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfoEntity
    {
        /// <summary>
        /// 会员基本信息
        /// </summary>
        public sline_member UserInfo { get; set; }

        /// <summary>
        /// 第三方用户-微信信息
        /// </summary>
        public sline_member_third OpenUserInfo { get; set; }
    }
}
