using LTHW.IBLL.Mysql;
using LTHW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.Common
{
    /// <summary>
    /// 行政区
    /// </summary>
    [RoutePrefix("api/region")]
    public class RegionController : ApiController
    {
        readonly IRegionBLL _IRegionBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iRegionBLL"></param>
        public RegionController(IRegionBLL iRegionBLL)
        {
            _IRegionBLL = iRegionBLL;
        }

        /// <summary>
        /// 省
        /// </summary>
        /// <returns></returns>
        [Route("getprovince")]
        public ResponseBody<List<sline_region_province>> GetProvince()
        {
            var provList = _IRegionBLL.GetProvince();
            return new ResponseBody<List<sline_region_province>> { Result = provList, Code = "", Message = "" };
        }

        /// <summary>
        /// 市
        /// </summary>
        /// <param name="provid">省份id</param>
        /// <returns></returns>
        [Route("getcitybyprovid")]
        public ResponseBody<List<sline_region_city>> GetCityByProvince(int provid)
        {
            var cityList = _IRegionBLL.GetCityByProvince(provid);
            return new ResponseBody<List<sline_region_city>> { Result = cityList, Code = "", Message = "" };
        }

        /// <summary>
        /// 区
        /// </summary>
        /// <param name="cityid">城市id</param>
        /// <returns></returns>
        [Route("getcountybycity")]
        public ResponseBody<List<sline_region_county>> GetCountyByCity(int cityid)
        {
            var countyList = _IRegionBLL.GetCountyByCity(cityid);
            return new ResponseBody<List<sline_region_county>> { Result = countyList, Code = "", Message = "" };
        }
    }
}
