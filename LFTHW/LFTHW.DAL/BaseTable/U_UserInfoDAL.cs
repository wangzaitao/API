using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class U_UserInfoDAL : BaseDAL<U_UserInfo>, IU_UserInfoDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserInfo = db.U_UserInfo.FirstOrDefault(s => s.UserID == id);  
                db.U_UserInfo.Remove(uUserInfo); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public U_UserInfo GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var uUserInfo = db.U_UserInfo.FirstOrDefault(s => s.UserID == id);
                return uUserInfo;
            }
        }

        public bool Update(U_UserInfo uUserInfo) {
            using (var db = new LFTHWDBModel())
            {
                var _uUserInfo = db.U_UserInfo.FirstOrDefault(s => s.UserID == uUserInfo.UserID);
                _uUserInfo.UserID = uUserInfo.UserID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
