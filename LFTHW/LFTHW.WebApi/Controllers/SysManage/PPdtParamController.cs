using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ppdtparam")]
    public class PPdtParamController : ApiController
        {
            readonly IP_PdtParamBLL _IP_PdtParamBLL;

            public PPdtParamController(IP_PdtParamBLL iP_PdtParamBLL)
            {
                _IP_PdtParamBLL = iP_PdtParamBLL;
            }

            [Route("getall")]
            public List<P_PdtParam> GetAll()
            {
                return _IP_PdtParamBLL.GetAll();
            }

            [Route("add")]
            public void PostAdd(P_PdtParam pPdtParam)
            {
                _IP_PdtParamBLL.Add(pPdtParam);
            }
        }
    }


