using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 分销关联用户
    /// </summary>
    public class FenxiaoGuanlianUsersEntity
    {
        /// <summary>
        /// 上级
        /// </summary>
        public List<UserInfoEntity> JuniorUsers { get; set; }

        /// <summary>
        /// 下级
        /// </summary>
        public List<UserInfoEntity> SuperiorUsers { get; set; }
    }
}
