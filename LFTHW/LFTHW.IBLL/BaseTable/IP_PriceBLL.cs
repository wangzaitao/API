using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.IBLL
{
    public interface IP_PriceBLL : IBaseBLL<P_Price>
    {
        bool Delete(int id);
        P_Price GetById(int id);
        bool Update(P_Price pPrice);

        bool Edit(List<P_Price> pPriceList);
    }
}
