using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_OrderDetailDAL : BaseDAL<UP_OrderDetail>, IUP_OrderDetailDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upOrderDetail = db.UP_OrderDetail.FirstOrDefault(s => s.ID == id);  
                db.UP_OrderDetail.Remove(upOrderDetail); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_OrderDetail GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upOrderDetail = db.UP_OrderDetail.FirstOrDefault(s => s.ID == id);
                return upOrderDetail;
            }
        }

        public bool Update(UP_OrderDetail upOrderDetail) {
            using (var db = new LFTHWDBModel())
            {
                var _upOrderDetail = db.UP_OrderDetail.FirstOrDefault(s => s.ID == upOrderDetail.ID);
                _upOrderDetail.ID = upOrderDetail.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
