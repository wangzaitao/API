using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_ParamGroupBLL : BaseBLL<P_ParamGroup>, IP_ParamGroupBLL
    {
        private readonly IP_ParamGroupDAL _IP_ParamGroupDAL;
        public P_ParamGroupBLL()
            : base()
        {
            _IP_ParamGroupDAL = new P_ParamGroupDAL();
        }

        public bool Delete(int id) {
            return _IP_ParamGroupDAL.Delete(id);
        }

        public P_ParamGroup GetById(int id)
        {
            return _IP_ParamGroupDAL.GetById(id);
        }
        public bool Update(P_ParamGroup pParamGroup)
        {
            return _IP_ParamGroupDAL.Update(pParamGroup);
        }
    }
}

