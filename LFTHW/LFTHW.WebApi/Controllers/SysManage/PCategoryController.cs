using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pcategory")]
    public class PCategoryController : ApiController
    {
        readonly IP_CategoryBLL _IP_CategoryBLL;

        public PCategoryController(IP_CategoryBLL iP_CategoryBLL)
        {
            _IP_CategoryBLL = iP_CategoryBLL;
        }

        [Route("getall")]
        public List<P_Category> GetAll()
        {
            return _IP_CategoryBLL.GetAll();
        }

        [Route("getbytypeid")]
        public List<P_Category> GetByTypeID(long typeid)
        {
            return _IP_CategoryBLL.GetByTypeID(typeid);
        }

        [Route("getpage")]
        public dynamic GetPage([FromUri]TypeQueryParam pageParam)
        {
            var list = _IP_CategoryBLL.GetPage(pageParam);
            return new { data = list, total = pageParam.total };
        }

        [Route("getbyid")]
        public P_Category Get(int id)
        {
            return _IP_CategoryBLL.GetById(id);
        }

        [Route("getbypid")]
        public List<P_Category> GetByPId(long pid)
        {
            return _IP_CategoryBLL.GetByPId(pid);
        }

        [Route("gettree")]
        public List<P_Category> GetTree(long pid)
        {
            return _IP_CategoryBLL.GetTree(pid);
        }

        [Route("add")]
        public P_Category PostAdd(P_Category pCategory)
        {
            return _IP_CategoryBLL.Add(pCategory);
        }

        [Route("edit")]
        public bool PostEdit(CategoryType categoryType)
        {
            return _IP_CategoryBLL.Edit(categoryType);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_CategoryBLL.Delete(id);
        }
    }
}


