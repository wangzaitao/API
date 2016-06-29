using LTHW.IBLL.Mysql;
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
            var id = _IUserBLL.EditWeixinUser(wxUserInfoEntity);
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

        /// <summary>
        /// 根据会员id或者微信openid获取会员信息
        /// </summary>
        /// <param name="mid">会员id-可选</param>
        /// <param name="thirdfrom">第三方来源，微信wx，可空</param>
        /// <param name="openid">微信openid-可选</param>
        /// <returns></returns>
        [Route("getuserinfo")]
        public ResponseBody<UserInfoEntity> GetUserInfo(int mid,string thirdfrom, string openid)
        {
            var userInfo = _IUserBLL.GetUserInfo(mid, thirdfrom, openid);
            return new ResponseBody<UserInfoEntity> { Result = userInfo, Code = "", Message = "" };
        }

        /// <summary>
        /// 根据会员id获取分销关联上下级
        /// </summary>
        /// <param name="mid">会员id-可选</param>
        /// <param name="thirdfrom">第三方来源，微信wx，可空</param>
        /// <returns></returns>
        [Route("getfenxiaousers")]
        public ResponseBody<FenxiaoGuanlianUsersEntity> GetFenxiaoGuanlianUsers(int mid, string thirdfrom)
        {
            var userInfo = _IUserBLL.GetFenxiaoGuanlianUsers(mid,thirdfrom);
            return new ResponseBody<FenxiaoGuanlianUsersEntity> { Result = userInfo, Code = "", Message = "" };
        }

        /// <summary>
        /// 根据上级(或上级+上上级...)查询下一级
        /// </summary>
        /// <param name="mid_pid">一级id+","+二级id+","+三级id+........，只有一个时不要逗号</param>
        /// <param name="thirdfrom">第三方来源，微信wx，可空</param>
        /// <returns></returns>
        [Route("getfenxiaousers")]
        public ResponseBody<List<UserInfoEntity>> GetUserInfoListByPid(string mid_pid, string thirdfrom)
        {
            var userInfoList = _IUserBLL.GetUserInfoListByPid(mid_pid, thirdfrom);
            return new ResponseBody<List<UserInfoEntity>> { Result = userInfoList, Code = "", Message = "" };
        }
    }
}
