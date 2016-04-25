using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_BrandBLL : BaseBLL<P_Brand>, IP_BrandBLL
    {
        private readonly IP_BrandDAL _IP_BrandDAL;
        public P_BrandBLL()
            : base()
        {
            _IP_BrandDAL = new P_BrandDAL();
        }

        public bool Delete(int id) {
            return _IP_BrandDAL.Delete(id);
        }

        public P_Brand GetById(int id)
        {
            return _IP_BrandDAL.GetById(id);
        }
        public bool Update(P_Brand pBrand)
        {
            return _IP_BrandDAL.Update(pBrand);
        }
    }
}

