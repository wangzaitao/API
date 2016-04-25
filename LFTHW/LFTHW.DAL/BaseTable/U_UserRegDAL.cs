using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class U_UserRegDAL : BaseDAL<U_UserReg>, IU_UserRegDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserReg = db.U_UserReg.FirstOrDefault(s => s.UserID == id);  
                db.U_UserReg.Remove(uUserReg); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public U_UserReg GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserReg = db.U_UserReg.FirstOrDefault(s => s.UserID == id);
                return uUserReg;
            }
        }

        public bool Update(U_UserReg uUserReg) {
            using (var db = new LFTHWDBModel())
            {
                var _uUserReg = db.U_UserReg.FirstOrDefault(s => s.UserID == uUserReg.UserID);
                _uUserReg.UserID = uUserReg.UserID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
