using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ppdtkeyword")]
    public class PPdtKeywordController : ApiController
        {
            readonly IP_PdtKeywordBLL _IP_PdtKeywordBLL;

            public PPdtKeywordController(IP_PdtKeywordBLL iP_PdtKeywordBLL)
            {
                _IP_PdtKeywordBLL = iP_PdtKeywordBLL;
            }

            [Route("getall")]
            public List<P_PdtKeyword> GetAll()
            {
                return _IP_PdtKeywordBLL.GetAll();
            }

            [Route("add")]
            public void PostAdd(P_PdtKeyword pPdtKeyword)
            {
                _IP_PdtKeywordBLL.Add(pPdtKeyword);
            }
        }
    }


