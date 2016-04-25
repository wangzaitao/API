using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class P_PriceBLL : BaseBLL<P_Price>, IP_PriceBLL
    {
        private readonly IP_PriceDAL _IP_PriceDAL;
        public P_PriceBLL()
            : base()
        {
            _IP_PriceDAL = new P_PriceDAL();
        }

        public bool Delete(int id) {
            return _IP_PriceDAL.Delete(id);
        }

        public P_Price GetById(int id)
        {
            return _IP_PriceDAL.GetById(id);
        }
        public bool Update(P_Price pPrice)
        {
            return _IP_PriceDAL.Update(pPrice);
        }
    }
}

