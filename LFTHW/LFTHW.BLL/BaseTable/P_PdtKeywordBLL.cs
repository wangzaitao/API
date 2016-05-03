using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_PdtKeywordBLL : BaseBLL<P_PdtKeyword>, IP_PdtKeywordBLL
    {
        private readonly IP_PdtKeywordDAL _IP_PdtKeywordDAL;
        public P_PdtKeywordBLL()
            : base()
        {
            _IP_PdtKeywordDAL = new P_PdtKeywordDAL();
        }
    }
}

