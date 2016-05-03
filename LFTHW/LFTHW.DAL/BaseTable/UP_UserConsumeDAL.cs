using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_UserConsumeDAL : BaseDAL<UP_UserConsume>, IUP_UserConsumeDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upUserConsume = db.UP_UserConsume.FirstOrDefault(s => s.ID == id);  
                db.UP_UserConsume.Remove(upUserConsume); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_UserConsume GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upUserConsume = db.UP_UserConsume.FirstOrDefault(s => s.ID == id);
                return upUserConsume;
            }
        }

        public bool Update(UP_UserConsume upUserConsume) {
            using (var db = new LFTHWDBModel())
            {
                var _upUserConsume = db.UP_UserConsume.FirstOrDefault(s => s.ID == upUserConsume.ID);
                _upUserConsume.ID = upUserConsume.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
