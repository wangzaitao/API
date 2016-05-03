using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_CategoryParamGroupBLL : BaseBLL<P_CategoryParamGroup>, IP_CategoryParamGroupBLL
    {
        private readonly IP_CategoryParamGroupDAL _IP_CategoryParamGroupDAL;
        public P_CategoryParamGroupBLL()
            : base()
        {
            _IP_CategoryParamGroupDAL = new P_CategoryParamGroupDAL();
        }

    }
}

