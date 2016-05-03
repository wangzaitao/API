using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_ParamBLL : BaseBLL<P_Param>, IP_ParamBLL
    {
        private readonly IP_ParamDAL _IP_ParamDAL;
        public P_ParamBLL()
            : base()
        {
            _IP_ParamDAL = new P_ParamDAL();
        }

        public bool Delete(int id) {
            return _IP_ParamDAL.Delete(id);
        }

        public P_Param GetById(int id)
        {
            return _IP_ParamDAL.GetById(id);
        }
        public bool Update(P_Param pParam)
        {
            return _IP_ParamDAL.Update(pParam);
        }
    }
}

