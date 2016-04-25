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

            [Route("add")]
            public void PostAdd(P_TypeCategory pTypeCategory)
            {
                _IP_TypeCategoryBLL.Add(pTypeCategory);
            }
        }
    }


