using System.Linq;
using LFTHW.Model;

namespace LFTHW.IDAL
{
    public interface IP_RouteDAL: IBaseDAL<P_Route>
    {
        bool Delete(int id);

        IQueryable<P_Route> GetByPdtID(long pdtID);

        bool Update(P_Route pRoute);
    }
}
