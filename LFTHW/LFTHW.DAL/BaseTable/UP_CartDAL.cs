using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_CartDAL : BaseDAL<UP_Cart>, IUP_CartDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upCart = db.UP_Cart.FirstOrDefault(s => s.ID == id);  
                db.UP_Cart.Remove(upCart); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_Cart GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upCart = db.UP_Cart.FirstOrDefault(s => s.ID == id);
                return upCart;
            }
        }

        public bool Update(UP_Cart upCart) {
            using (var db = new LFTHWDBModel())
            {
                var _upCart = db.UP_Cart.FirstOrDefault(s => s.ID == upCart.ID);
                _upCart.ID = upCart.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
