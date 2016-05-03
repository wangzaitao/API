using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class P_BrandDAL : BaseDAL<P_Brand>, IP_BrandDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pBrand = db.P_Brand.FirstOrDefault(s => s.ID == id);  
                db.P_Brand.Remove(pBrand); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public P_Brand GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var pBrand = db.P_Brand.FirstOrDefault(s => s.ID == id);
                return pBrand;
            }
        }

        public bool Update(P_Brand pBrand) {
            using (var db = new LFTHWDBModel())
            {
                var _pBrand = db.P_Brand.FirstOrDefault(s => s.ID == pBrand.ID);
                _pBrand.ID = pBrand.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
