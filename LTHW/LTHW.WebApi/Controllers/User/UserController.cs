﻿using LTHW.IBLL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.User
{
    /// <summary>
    /// 会员
    /// </summary>
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        readonly IUserBLL _IUserBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iUserBLL"></param>
        public UserController(IUserBLL iUserBLL)
        {
            _IUserBLL = iUserBLL;
        }

        /// <summary>
        /// 微信信息-保存
        /// </summary>
        /// <returns></returns>
        [Route("postwxuser")]
        public ResponseBody<int> PostWXUser(WXUserInfoEntity wxUserInfoEntity)
        {
            var id = _IUserBLL.AddWeixinUser(wxUserInfoEntity);
            return new ResponseBody<int> { Result = id, Code = "", Message = "" };
        }

        /// <summary>
        /// 查询所有会员
        /// </summary>
        /// <returns></returns>
        [Route("getalluser")]
        public ResponseBody<List<sline_member>> GetAllUser()
        {
            var list = _IUserBLL.GetAll();
            return new ResponseBody<List<sline_member>> { Result = list, Code = "", Message = "" };
        }
    }
}
