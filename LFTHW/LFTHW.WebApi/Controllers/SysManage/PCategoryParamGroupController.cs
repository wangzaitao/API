using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pcategoryparamgroup")]
    public class PCategoryParamGroupController : ApiController
    {
        readonly IP_CategoryParamGroupBLL _IP_CategoryParamGroupBLL;

        public PCategoryParamGroupController(IP_CategoryParamGroupBLL iP_CategoryParamGroupBLL)
        {
            _IP_CategoryParamGroupBLL = iP_CategoryParamGroupBLL;
        }

        [Route("getall")]
        public List<P_CategoryParamGroup> GetAll()
        {
            return _IP_CategoryParamGroupBLL.GetAll();
        }

        [Route("add")]
        public P_CategoryParamGroup PostAdd(P_CategoryParamGroup pCategoryParamGroup)
        {
            return _IP_CategoryParamGroupBLL.Add(pCategoryParamGroup);
        }
    }
}


