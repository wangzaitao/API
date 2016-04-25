using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_PriceDAL : BaseDAL<P_Price>, IP_PriceDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPrice = db.P_Price.FirstOrDefault(s => s.ID == id);  
                db.P_Price.Remove(pPrice); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Price GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pPrice = db.P_Price.FirstOrDefault(s => s.ID == id);
                return pPrice;
            }
        }

        public bool Update(P_Price pPrice) {
            using (var db = new LFTHWDBModel())
            {
                var _pPrice = db.P_Price.FirstOrDefault(s => s.ID == pPrice.ID);
                _pPrice.ID = pPrice.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
