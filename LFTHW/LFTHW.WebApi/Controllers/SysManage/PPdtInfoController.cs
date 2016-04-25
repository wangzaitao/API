using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ppdtinfo")]
    public class PPdtInfoController : ApiController
        {
            readonly IP_PdtInfoBLL _IP_PdtInfoBLL;

            public PPdtInfoController(IP_PdtInfoBLL iP_PdtInfoBLL)
            {
                _IP_PdtInfoBLL = iP_PdtInfoBLL;
            }

            [Route("getall")]
            public List<P_PdtInfo> GetAll()
            {
                return _IP_PdtInfoBLL.GetAll();
            }

            [Route("getbyid")]
            public P_PdtInfo Get(int id)
            {
                return _IP_PdtInfoBLL.GetById(id);
            }

            [Route("add")]
            public void PostAdd(P_PdtInfo pPdtInfo)
            {
                _IP_PdtInfoBLL.Add(pPdtInfo);
            }

            [Route("update")]
            public void PostEdit(P_PdtInfo pPdtInfo)
            {
                _IP_PdtInfoBLL.Update(pPdtInfo, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IP_PdtInfoBLL.Delete(id);
            }
        }
    }


