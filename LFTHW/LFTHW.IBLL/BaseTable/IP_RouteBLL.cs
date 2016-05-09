using System.Collections.Generic;
using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IP_RouteBLL : IBaseBLL<P_Route>
    {
        bool Delete(int id);
        List<P_Route> GetByPdtID(long pdtID);
        bool Update(P_Route pRoute);
    }
}
