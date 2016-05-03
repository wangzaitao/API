using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_OrderBLL : BaseBLL<UP_Order>, IUP_OrderBLL
    {
        private readonly IUP_OrderDAL _IUP_OrderDAL;
        public UP_OrderBLL()
            : base()
        {
            _IUP_OrderDAL = new UP_OrderDAL();
        }

        public bool Delete(int id) {
            return _IUP_OrderDAL.Delete(id);
        }

        public UP_Order GetById(int id)
        {
            return _IUP_OrderDAL.GetById(id);
        }
        public bool Update(UP_Order upOrder)
        {
            return _IUP_OrderDAL.Update(upOrder);
        }
    }
}

