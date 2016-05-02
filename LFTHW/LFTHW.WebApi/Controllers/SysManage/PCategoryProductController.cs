using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pcategoryproduct")]
    public class PCategoryProductController : ApiController
    {
        readonly IP_CategoryProductBLL _IP_CategoryProductBLL;

        public PCategoryProductController(IP_CategoryProductBLL iP_CategoryProductBLL)
        {
            _IP_CategoryProductBLL = iP_CategoryProductBLL;
        }

        [Route("getall")]
        public List<P_CategoryProduct> GetAll()
        {
            return _IP_CategoryProductBLL.GetAll();
        }

        [Route("add")]
        public P_CategoryProduct PostAdd(P_CategoryProduct pCategoryProduct)
        {
            return _IP_CategoryProductBLL.Add(pCategoryProduct);
        }
    }
}


