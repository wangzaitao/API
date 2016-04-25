using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/ptype")]
    public class PTypeController : ApiController
    {
        readonly IP_TypeBLL _IP_TypeBLL;

        public PTypeController(IP_TypeBLL iP_TypeBLL)
        {
            _IP_TypeBLL = iP_TypeBLL;
        }

        [Route("getall")]
        public List<P_Type> GetAll()
        {
            return _IP_TypeBLL.GetAll();
        }

        [Route("getbyid")]
        public P_Type Get(int id)
        {
            return _IP_TypeBLL.GetById(id);
        }

        [Route("add")]
        public void PostAdd(P_Type pType)
        {
            _IP_TypeBLL.Add(pType);
        }

        [Route("update")]
        public void PostEdit(P_Type pType)
        {
            _IP_TypeBLL.Update(pType, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_TypeBLL.Delete(id);
        }
    }
}
