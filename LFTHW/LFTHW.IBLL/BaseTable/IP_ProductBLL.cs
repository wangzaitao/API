using System.Collections.Generic;
using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IP_ProductBLL : IBaseBLL<P_Product>
    {
        bool Delete(int id);
        CategoryProduct GetById(int id);
        bool Update(P_Product pProduct);

        bool Edit(ProductBasicInfo product);

        List<CategoryProduct> GetByWhere(PdtQueryParam pdtParam);
    }
}
