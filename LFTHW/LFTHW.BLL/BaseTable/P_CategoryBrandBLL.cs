using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_CategoryBrandBLL : BaseBLL<P_CategoryBrand>, IP_CategoryBrandBLL
    {
        private readonly IP_CategoryBrandDAL _IP_CategoryBrandDAL;
        public P_CategoryBrandBLL()
            : base()
        {
            _IP_CategoryBrandDAL = new P_CategoryBrandDAL();
        }
    }
}

