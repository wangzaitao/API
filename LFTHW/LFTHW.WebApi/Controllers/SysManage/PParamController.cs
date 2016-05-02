using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pparam")]
    public class PParamController : ApiController
        {
            readonly IP_ParamBLL _IP_ParamBLL;

            public PParamController(IP_ParamBLL iP_ParamBLL)
            {
                _IP_ParamBLL = iP_ParamBLL;
            }

            [Route("getall")]
            public List<P_Param> GetAll()
            {
                return _IP_ParamBLL.GetAll();
            }

            [Route("getbyid")]
            public P_Param Get(int id)
            {
                return _IP_ParamBLL.GetById(id);
            }

            [Route("add")]
            public P_Param PostAdd(P_Param pParam)
            {
                return _IP_ParamBLL.Add(pParam);
            }

            [Route("update")]
            public bool PostEdit(P_Param pParam)
            {
                return _IP_ParamBLL.Update(pParam, null);
            }

            [Route("delete")]
            public bool Delete(int id)
            {
                return _IP_ParamBLL.Delete(id);
            }
        }
    }


