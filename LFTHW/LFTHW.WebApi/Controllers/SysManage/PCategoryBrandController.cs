using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pcategorybrand")]
    public class PCategoryBrandController : ApiController
        {
            readonly IP_CategoryBrandBLL _IP_CategoryBrandBLL;

            public PCategoryBrandController(IP_CategoryBrandBLL iP_CategoryBrandBLL)
            {
                _IP_CategoryBrandBLL = iP_CategoryBrandBLL;
            }

            [Route("getall")]
            public List<P_CategoryBrand> GetAll()
            {
                return _IP_CategoryBrandBLL.GetAll();
            }

            [Route("add")]
            public void PostAdd(P_CategoryBrand pCategoryBrand)
            {
                _IP_CategoryBrandBLL.Add(pCategoryBrand);
            }
        }
    }


