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
    /// 线路
    /// </summary>
    [RoutePrefix("api/trips")]
    public class TripsController : ApiController
    {
        readonly ITripsBLL _ITripsBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iTripsBLL"></param>
        public TripsController(ITripsBLL iTripsBLL)
        {
            _ITripsBLL = iTripsBLL;
        }

        /// <summary>
        /// 获取所有线路信息
        /// </summary>
        /// <returns></returns>
        [Route("getall")]
        public List<sline_line> GetAll()
        {
            return _ITripsBLL.GetAll();
        }

        /// <summary>
        /// 获取线路分页信息
        /// </summary>
        /// <returns>列表基本数据</returns>
        [Route("postpage")]
        public ResponseBody postPage([FromBody]TripQueryParam pageParam)
        {
            var list = _ITripsBLL.GetPage(pageParam);
            return new ResponseBody { Result = new { data = list, total = pageParam.total }, Code="",Message="" };
        }

        /// <summary>
        /// 获取线路详细信息
        /// </summary>
        /// <returns>线路详细信息</returns>
        [Route("getbyid")]
        public ResponseBody getById(int id)
        {
            var list = _ITripsBLL.getById(id);
            return new ResponseBody { Result = list, Code = "", Message = "" };
        }
    }
}
