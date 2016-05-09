using System.Collections.Generic;
using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IP_PriceBLL : IBaseBLL<P_Price>
    {
        bool Delete(int id);
        List<P_Price> GetByPdtID(long pdtID);
        bool Update(P_Price pPrice);

        bool Edit(List<P_Price> pPriceList);
    }
}
