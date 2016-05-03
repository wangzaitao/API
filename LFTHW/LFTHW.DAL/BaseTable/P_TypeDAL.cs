using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_TypeDAL : BaseDAL<P_Type>, IP_TypeDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pType = db.P_Type.FirstOrDefault(s => s.ID == id);  
                db.P_Type.Remove(pType); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Type GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pType = db.P_Type.FirstOrDefault(s => s.ID == id);
                return pType;
            }
        }

        public bool Update(P_Type pType) {
            using (var db = new LFTHWDBModel())
            {
                var _pType = db.P_Type.FirstOrDefault(s => s.ID == pType.ID);
                _pType.ShopID = pType.ShopID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
