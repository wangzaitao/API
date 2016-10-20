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
        public ResponseBody<List<sline_line>> GetAll()
        {
            var list = _ITripsBLL.GetAll();
            return new ResponseBody<List<sline_line>> { Result = list, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取线路分页信息
        /// </summary>
        /// <returns>列表基本数据</returns>
        [Route("postpage")]
        public ResponseBody<PageEntity<List<TripListEntity>>> PostPage([FromBody]TripQueryParam pageParam)
        {
            var list = _ITripsBLL.GetPage(pageParam);
            return new ResponseBody<PageEntity<List<TripListEntity>>> { Result = new PageEntity<List<TripListEntity>> { data = list, total = pageParam.total }, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取线路详细信息
        /// </summary>
        /// <param name="id">线路id</param>
        /// <returns>线路详细信息</returns>
        [Route("getbyid/{id}")]
        public ResponseBody<TripInfoEntity> GetById(int id)
        {
            var tripInfo = _ITripsBLL.GetById(id);
            return new ResponseBody<TripInfoEntity> { Result = tripInfo, Code = "", Message = "" };
        }
    }
}
