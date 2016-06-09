using LTHW.IBLL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.WebSite
{
    /// <summary>
    /// 目的地
    /// </summary>
    [RoutePrefix("api/mudidi")]
    public class MuDiDiController : ApiController
    {
        readonly IMuDiDiBLL _IMuDiDiBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iMuDiDiBLL"></param>
        public MuDiDiController(IMuDiDiBLL iMuDiDiBLL)
        {
            _IMuDiDiBLL = iMuDiDiBLL;
        }

        /// <summary>
        /// 获取所有目的地信息-树形
        /// </summary>
        /// <param name="pid">父id</param>
        /// <returns></returns>
        [Route("gettree/{pid}")]
        public ResponseBody GetTree(long pid)
        {
            var list = _IMuDiDiBLL.GetTree(pid);
            return new ResponseBody { Result = list, Code = "", Message = "" };
        }
    }
}
