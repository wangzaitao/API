using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_OrderDetailBLL : BaseBLL<UP_OrderDetail>, IUP_OrderDetailBLL
    {
        private readonly IUP_OrderDetailDAL _IUP_OrderDetailDAL;
        public UP_OrderDetailBLL()
            : base()
        {
            _IUP_OrderDetailDAL = new UP_OrderDetailDAL();
        }

        public bool Delete(int id) {
            return _IUP_OrderDetailDAL.Delete(id);
        }

        public UP_OrderDetail GetById(int id)
        {
            return _IUP_OrderDetailDAL.GetById(id);
        }
        public bool Update(UP_OrderDetail upOrderDetail)
        {
            return _IUP_OrderDetailDAL.Update(upOrderDetail);
        }
    }
}

