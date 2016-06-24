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
    /// 景点
    /// </summary>
    [RoutePrefix("api/sight")]
    public class SightController : ApiController
    {
        readonly ISightBLL _ISightBLL;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iSightBLL"></param>
        public SightController(ISightBLL iSightBLL)
        {
            _ISightBLL = iSightBLL;
        }

        /// <summary>
        /// 获取所有景点信息
        /// </summary>
        /// <returns></returns>
        [Route("getall")]
        public ResponseBody<List<sline_spot>> GetAll()
        {
            var list = _ISightBLL.GetAll();
            return new ResponseBody<List<sline_spot>> { Result = list, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取景点分页信息
        /// </summary>
        /// <returns>列表基本数据</returns>
        [Route("postpage")]
        public ResponseBody<PageEntity<List<SightListEntity>>> PostPage([FromBody]SightQueryParam pageParam)
        {
            var list = _ISightBLL.GetPage(pageParam);
            return new ResponseBody<PageEntity<List<SightListEntity>>> { Result = new PageEntity<List<SightListEntity>> { data = list, total = pageParam.total }, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取景点详细信息
        /// </summary>
        /// <param name="id">景点id</param>
        /// <returns>景点详细信息</returns>
        [Route("getbyid/{id}")]
        public ResponseBody<SightInfoEntity> GetById(int id)
        {
            var list = _ISightBLL.GetById(id);
            return new ResponseBody<SightInfoEntity> { Result = list, Code = "", Message = "" };
        }

        /// <summary>
        /// 获取所有景点属性分类-树形
        /// </summary>
        /// <param name="pid">父id</param>
        /// <returns></returns>
        [Route("getspotattrtree/{pid}")]
        public ResponseBody<List<TreeObject>> GetSpotAttrTree(long pid)
        {
            var list = _ISightBLL.GetSpotAttrTree(pid);
            return new ResponseBody<List<TreeObject>> { Result = list, Code = "", Message = "" };
        }
    }
}
