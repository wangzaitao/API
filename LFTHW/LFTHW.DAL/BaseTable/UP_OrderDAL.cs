using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_OrderDAL : BaseDAL<UP_Order>, IUP_OrderDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upOrder = db.UP_Order.FirstOrDefault(s => s.ID == id);  
                db.UP_Order.Remove(upOrder); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_Order GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upOrder = db.UP_Order.FirstOrDefault(s => s.ID == id);
                return upOrder;
            }
        }

        public bool Update(UP_Order upOrder) {
            using (var db = new LFTHWDBModel())
            {
                var _upOrder = db.UP_Order.FirstOrDefault(s => s.ID == upOrder.ID);
                _upOrder.ID = upOrder.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
