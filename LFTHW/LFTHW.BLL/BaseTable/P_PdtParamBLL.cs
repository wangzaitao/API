using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_PdtParamBLL : BaseBLL<P_PdtParam>, IP_PdtParamBLL
    {
        private readonly IP_PdtParamDAL _IP_PdtParamDAL;
        public P_PdtParamBLL()
            : base()
        {
            _IP_PdtParamDAL = new P_PdtParamDAL();
        }
    }
}

