using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_CartBLL : BaseBLL<UP_Cart>, IUP_CartBLL
    {
        private readonly IUP_CartDAL _IUP_CartDAL;
        public UP_CartBLL()
            : base()
        {
            _IUP_CartDAL = new UP_CartDAL();
        }

        public bool Delete(int id) {
            return _IUP_CartDAL.Delete(id);
        }

        public UP_Cart GetById(int id)
        {
            return _IUP_CartDAL.GetById(id);
        }
        public bool Update(UP_Cart upCart)
        {
            return _IUP_CartDAL.Update(upCart);
        }
    }
}

