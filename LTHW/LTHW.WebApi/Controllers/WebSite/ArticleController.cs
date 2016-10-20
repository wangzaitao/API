using LTHW.IBLL.Mysql;
using LTHW.Model;
using LTHW.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LTHW.WebApi.Controllers.WebSite
{
    /// <summary>
    /// 文章
    /// </summary>
    [RoutePrefix("api/article")]
    public class ArticleController : ApiController
    {
        readonly IArticleBLL _IArticleBLL;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="iArticleBLL"></param>
        public ArticleController(IArticleBLL iArticleBLL)
        {
            _IArticleBLL = iArticleBLL;
        }

        /// <summary>
        /// 获取文章分页信息
        /// </summary>
        /// <returns>列表基本数据</returns>
        [Route("postpage")]
        public ResponseBody<PageEntity<List<sline_article>>> PostPage([FromBody]ArticleQueryParam pageParam)
        {
            try
            {
                var list = _IArticleBLL.GetPage(pageParam);
                return new ResponseBody<PageEntity<List<sline_article>>> { Result = new PageEntity<List<sline_article>> { data = list, total = pageParam.total }, Code = "", Message = "" };
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, ex.Message + ex.InnerException.Message);
                return null;
            }
        }

        /// <summary>
        /// 获取文章详细信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>文章详细信息</returns>
        [Route("getbyid/{id}")]
        public ResponseBody<sline_article> GetById(int id)
        {
            try
            {
                var info = _IArticleBLL.GetById(id);
                return new ResponseBody<sline_article> { Result = info, Code = "", Message = "" };
            }
            catch (Exception ex)
            {
                LogHelper.Error(this, ex.Message + ex.InnerException.Message);
                return null;
            }
        }
    }
}
