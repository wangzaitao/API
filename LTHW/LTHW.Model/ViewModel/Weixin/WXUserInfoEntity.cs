﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHW.Model
{
    /// <summary>
    /// 微信用户
    /// </summary>
    public class WXUserInfoEntity:sline_member_third
    {   
        /// <summary>
        /// 推荐人微信openid
        /// </summary>
        public string recommendopenid { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string pwd { get; set; }
    }
}
