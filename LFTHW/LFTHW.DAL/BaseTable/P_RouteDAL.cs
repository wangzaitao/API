using System.Linq;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_RouteDAL : BaseDAL<P_Route>, IP_RouteDAL
    {
        public bool Delete(int id)
        {
            using (var db = new LFTHWDBModel())
            {
                var pRoute = db.P_Route.FirstOrDefault(s => s.ID == id);
                db.P_Route.Remove(pRoute);
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public IQueryable<P_Route> GetByPdtID(long pdtID)
        {
            var db = new LFTHWDBModel();
            var pRoute = db.P_Route.Where(s => s.PdtID == pdtID);
            return pRoute;
        }

        public bool Update(P_Route pRoute)
        {
            using (var db = new LFTHWDBModel())
            {
                var _pRoute = db.P_Route.FirstOrDefault(s => s.ID == pRoute.ID);
                _pRoute.ID = pRoute.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
