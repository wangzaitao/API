using LTHW.IBLL.Mysql;
using LTHW.Model;
//using LTHW.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.WebSite
{
    /// <summary>
    /// 酒店
    /// </summary>    
    [RoutePrefix("api/hotel")]
    //[WebApiExceptionFilter]
    public class HotelController : ApiController
    {
        readonly IHotelBLL _IHotelBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iHotelBLL"></param>
        public HotelController(IHotelBLL iHotelBLL)
        {
            _IHotelBLL = iHotelBLL;
        }

        /// <summary>
        /// 获取所有酒店信息
        /// </summary>
        /// <returns></returns>
        [Route("getall")]
        public ResponseBody<List<sline_hotel>> GetAll()
        {
            var list = _IHotelBLL.GetAll();
            return new ResponseBody<List<sline_hotel>> { Result = list, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取酒店分页信息
        /// </summary>
        /// <returns>列表基本数据</returns>
        [Route("postpage")]
        public ResponseBody<PageEntity<List<HotelListEntity>>> PostPage([FromBody]HotelQueryParam pageParam)
        {
            var list = _IHotelBLL.GetPage(pageParam);
            return new ResponseBody<PageEntity<List<HotelListEntity>>> { Result = new PageEntity < List < HotelListEntity >> { data = list, total = pageParam.total }, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取酒店详细信息
        /// </summary>
        /// <param name="id">酒店id</param>
        /// <returns>酒店详细信息</returns>
        [Route("getbyid/{id}")]
        public ResponseBody<HotelInfoEntity> GetById(int id)
        {
            var hotelInfo = _IHotelBLL.GetById(id);
            return new ResponseBody<HotelInfoEntity> { Result = hotelInfo, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取所有酒店属性分类-树形
        /// </summary>
        /// <param name="pid">父id</param>
        /// <returns></returns>
        [Route("gethotelattrtree/{pid}")]
        public ResponseBody<List<TreeObject>> GetHotelAttrTree(long pid)
        {
            var list = _IHotelBLL.GetHotelAttrTree(pid);
            return new ResponseBody<List<TreeObject>> { Result = list, Code = "", Message = "" };
        }
    }
}
