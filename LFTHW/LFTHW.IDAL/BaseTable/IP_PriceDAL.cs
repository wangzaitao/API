﻿using LFTHW.Model;
using System.Collections.Generic;

namespace LFTHW.IDAL
{
    public interface IP_PriceDAL: IBaseDAL<P_Price>
    {
        bool Delete(int id);

        P_Price GetById(int id);

        bool Update(P_Price pPrice);

        bool Edit(List<P_Price> pPriceList,long pdtID);
    }
}
