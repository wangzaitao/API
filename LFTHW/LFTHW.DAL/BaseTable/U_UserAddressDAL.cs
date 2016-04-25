using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class U_UserAddressDAL : BaseDAL<U_UserAddress>, IU_UserAddressDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserAddress = db.U_UserAddress.FirstOrDefault(s => s.ID == id);  
                db.U_UserAddress.Remove(uUserAddress); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public U_UserAddress GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserAddress = db.U_UserAddress.FirstOrDefault(s => s.ID == id);
                return uUserAddress;
            }
        }

        public bool Update(U_UserAddress uUserAddress) {
            using (var db = new LFTHWDBModel())
            {
                var _uUserAddress = db.U_UserAddress.FirstOrDefault(s => s.ID == uUserAddress.ID);
                _uUserAddress.ID = uUserAddress.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
