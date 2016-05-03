using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ptypecategory")]
    public class PTypeCategoryController : ApiController
    {
        readonly IP_TypeCategoryBLL _IP_TypeCategoryBLL;

        public PTypeCategoryController(IP_TypeCategoryBLL iP_TypeCategoryBLL)
        {
            _IP_TypeCategoryBLL = iP_TypeCategoryBLL;
        }

        [Route("getall")]
        public List<P_TypeCategory> GetAll()
        {
            return _IP_TypeCategoryBLL.GetAll();
        }

        [Route("gettree")]
        public List<TreeObject> GetTree()
        {
            return _IP_TypeCategoryBLL.GetTree();
        }

        [Route("add")]
        public P_TypeCategory PostAdd(P_TypeCategory pTypeCategory)
        {
            return _IP_TypeCategoryBLL.Add(pTypeCategory);
        }
    }
}


