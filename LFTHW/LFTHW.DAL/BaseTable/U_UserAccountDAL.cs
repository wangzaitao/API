using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class U_UserAccountDAL : BaseDAL<U_UserAccount>, IU_UserAccountDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserAccount = db.U_UserAccount.FirstOrDefault(s => s.UserID == id);  
                db.U_UserAccount.Remove(uUserAccount); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public U_UserAccount GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserAccount = db.U_UserAccount.FirstOrDefault(s => s.UserID == id);
                return uUserAccount;
            }
        }

        public bool Update(U_UserAccount uUserAccount) {
            using (var db = new LFTHWDBModel())
            {
                var _uUserAccount = db.U_UserAccount.FirstOrDefault(s => s.UserID == uUserAccount.UserID);
                _uUserAccount.UserID = uUserAccount.UserID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
