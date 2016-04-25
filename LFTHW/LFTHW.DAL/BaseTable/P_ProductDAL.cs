using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_ProductDAL : BaseDAL<P_Product>, IP_ProductDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pProduct = db.P_Product.FirstOrDefault(s => s.ID == id);  
                db.P_Product.Remove(pProduct); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Product GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pProduct = db.P_Product.FirstOrDefault(s => s.ID == id);
                return pProduct;
            }
        }

        public bool Update(P_Product pProduct) {
            using (var db = new LFTHWDBModel())
            {
                var _pProduct = db.P_Product.FirstOrDefault(s => s.ID == pProduct.ID);
                _pProduct.ID = pProduct.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
