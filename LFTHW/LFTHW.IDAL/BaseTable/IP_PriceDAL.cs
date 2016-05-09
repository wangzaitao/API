using System.Collections.Generic;
using System.Linq;
using LFTHW.Model;

namespace LFTHW.IDAL
{
    public interface IP_PriceDAL: IBaseDAL<P_Price>
    {
        bool Delete(int id);

        IQueryable<P_Price> GetByPdtID(long pdtID);

        bool Update(P_Price pPrice);

        bool Edit(List<P_Price> pPriceList,long pdtID);
    }
}
