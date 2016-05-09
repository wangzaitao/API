using System.Web.Http;
using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.Model;

namespace LFTHW.WebApi.Controllers.SysManage
{
    [RoutePrefix("api/proute")]
    public class PRouteController : ApiController
    {
        readonly IP_RouteBLL _IP_RouteBLL;

        public PRouteController(IP_RouteBLL iP_RouteBLL)
        {
            _IP_RouteBLL = iP_RouteBLL;
        }

        [Route("getall")]
        public List<P_Route> GetAll()
        {
            return _IP_RouteBLL.GetAll();
        }

        [Route("getbypdtid")]
        public List<P_Route> Get(int pdtID)
        {
            return _IP_RouteBLL.GetByPdtID(pdtID);
        }

        [Route("add")]
        public P_Route PostAdd(P_Route pRoute)
        {
            return _IP_RouteBLL.Add(pRoute);
        }

        [Route("update")]
        public bool PostEdit(P_Route pRoute)
        {
            return _IP_RouteBLL.Update(pRoute, null);
        }

        [Route("delete")]
        public bool Delete(int id)
        {
            return _IP_RouteBLL.Delete(id);
        }
    }
}


