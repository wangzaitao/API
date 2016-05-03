using System.Linq;
using System.Collections.Generic;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;
using LFTHW.DAL;

namespace LFTHW.BLL
{
    public class P_ProductBLL : BaseBLL<P_Product>, IP_ProductBLL
    {
        private readonly IP_ProductDAL _IP_ProductDAL;
        public P_ProductBLL()
            : base()
        {
            _IP_ProductDAL = new P_ProductDAL();
        }

        public bool Delete(int id) {
            return _IP_ProductDAL.Delete(id);
        }

        public CategoryProduct GetById(int id)
        {
            return _IP_ProductDAL.GetById(id);
        }
        public bool Update(P_Product pProduct)
        {
            return _IP_ProductDAL.Update(pProduct);
        }

        public bool Edit(ProductBasicInfo product) {
            return _IP_ProductDAL.Edit(product);
        }

        public List<CategoryProduct> GetByWhere(PdtQueryParam pdtParam) {
            return _IP_ProductDAL.GetByWhere(pdtParam).ToList<CategoryProduct>();
        }
    }
}

