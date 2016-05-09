using System.Collections.Generic;
using System.Linq;
using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_RouteBLL : BaseBLL<P_Route>, IP_RouteBLL
    {
        private readonly IP_RouteDAL _IP_RouteDAL;
        public P_RouteBLL()
            : base()
        {
            _IP_RouteDAL = new P_RouteDAL();
        }

        public bool Delete(int id) {
            return _IP_RouteDAL.Delete(id);
        }

        public List<P_Route> GetByPdtID(long pdtID)
        {
            return _IP_RouteDAL.GetByPdtID(pdtID).ToList<P_Route>();
        }
        public bool Update(P_Route pRoute)
        {
            return _IP_RouteDAL.Update(pRoute);
        }
    }
}

