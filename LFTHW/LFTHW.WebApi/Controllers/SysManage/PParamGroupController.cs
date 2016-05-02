using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/pparamgroup")]
    public class PParamGroupController : ApiController
    {
        readonly IP_ParamGroupBLL _IP_ParamGroupBLL;

        public PParamGroupController(IP_ParamGroupBLL iP_ParamGroupBLL)
        {
            _IP_ParamGroupBLL = iP_ParamGroupBLL;
        }

        [Route("getall")]
        public List<P_ParamGroup> GetAll()
        {
            return _IP_ParamGroupBLL.GetAll();
        }

        [Route("getbyid")]
        public P_ParamGroup Get(int id)
        {
            return _IP_ParamGroupBLL.GetById(id);
        }

        [Route("add")]
        public P_ParamGroup PostAdd(P_ParamGroup pParamGroup)
        {
            return _IP_ParamGroupBLL.Add(pParamGroup);
        }

        [Route("update")]
        public bool PostEdit(P_ParamGroup pParamGroup)
        {
            return _IP_ParamGroupBLL.Update(pParamGroup, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_ParamGroupBLL.Delete(id);
        }
    }
}


