using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_TypeCategoryBLL : BaseBLL<P_TypeCategory>, IP_TypeCategoryBLL
    {
        private readonly IP_TypeCategoryDAL _IP_TypeCategoryDAL;
        public P_TypeCategoryBLL()
            : base()
        {
            _IP_TypeCategoryDAL = new P_TypeCategoryDAL();
        }
    }
}

