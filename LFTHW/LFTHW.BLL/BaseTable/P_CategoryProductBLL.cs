using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_CategoryProductBLL : BaseBLL<P_CategoryProduct>, IP_CategoryProductBLL
    {
        private readonly IP_CategoryProductDAL _IP_CategoryProductDAL;
        public P_CategoryProductBLL()
            : base()
        {
            _IP_CategoryProductDAL = new P_CategoryProductDAL();
        }
    }
}

