using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_PdtInfoBLL : BaseBLL<P_PdtInfo>, IP_PdtInfoBLL
    {
        private readonly IP_PdtInfoDAL _IP_PdtInfoDAL;
        public P_PdtInfoBLL()
            : base()
        {
            _IP_PdtInfoDAL = new P_PdtInfoDAL();
        }

        public bool Delete(int id) {
            return _IP_PdtInfoDAL.Delete(id);
        }

        public P_PdtInfo GetById(int id)
        {
            return _IP_PdtInfoDAL.GetById(id);
        }
        public bool Update(P_PdtInfo pPdtInfo)
        {
            return _IP_PdtInfoDAL.Update(pPdtInfo);
        }

        public bool UpdateTripInfoRoute(TripInfoRoute tripInfoRoute, string[] property) {
            return _IP_PdtInfoDAL.UpdateTripInfoRoute(tripInfoRoute, property);
        }
    }
}

