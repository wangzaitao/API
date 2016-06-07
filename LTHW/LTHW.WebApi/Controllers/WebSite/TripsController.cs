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
    [RoutePrefix("api/trips")]
    public class TripsController : ApiController
    {
        readonly ITripsBLL _ITripsBLL;

        public TripsController(ITripsBLL iTripsBLL)
        {
            _ITripsBLL = iTripsBLL;
        }

        /// <summary>
        /// 获取所有线路信息
        /// </summary>
        /// <param name="istop">是否置顶</param>
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
        [Route("getpage")]
        public ResponseBody getPage([FromUri]TripQueryParam pageParam)
        {
            var list = _ITripsBLL.GetPage(pageParam);
            //return list;
            return new ResponseBody { Data = new { data = list, total = pageParam.total }, Code="",Message="" };
        }
    }
}
