using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_TypeBLL : BaseBLL<P_Type>, IP_TypeBLL
    {
        private readonly IP_TypeDAL _IP_TypeDAL;
        public P_TypeBLL()
            : base()
        {
            _IP_TypeDAL = new P_TypeDAL();
        }

        public bool Delete(int id) {
            return _IP_TypeDAL.Delete(id);
        }

        public P_Type GetById(int id)
        {
            return _IP_TypeDAL.GetById(id);
        }
        public bool Update(P_Type pType)
        {
            return _IP_TypeDAL.Update(pType);
        }
    }
}
