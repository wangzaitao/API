using LTHW.IBLL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;

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


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="strUser"></param>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("login")]
        public object Login(string strUser, string strPwd)
        {
            if (!ValidateUser(strUser, strPwd))
            {
                return new { bRes = false };
            }
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(0, strUser, DateTime.Now,
                            DateTime.Now.AddHours(1), true, string.Format("{0}&{1}", strUser, strPwd),
                            FormsAuthentication.FormsCookiePath);
            //返回登录结果、用户信息、用户验证票据信息
            var oUser = new UserInfo { bRes = true, UserName = strUser, Password = strPwd, Ticket = FormsAuthentication.Encrypt(ticket) };
            //将身份信息保存在session中，验证当前请求是否是有效请求
            HttpContext.Current.Session[strUser] = oUser;
            return oUser;
        }

        //校验用户名密码（正式环境中应该是数据库校验）
        private bool ValidateUser(string strUser, string strPwd)
        {
            if (strUser == "admin" && strPwd == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class UserInfo
    {
        public bool bRes { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Ticket { get; set; }
    }
}
