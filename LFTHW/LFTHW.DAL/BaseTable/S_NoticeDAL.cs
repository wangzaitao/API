using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class S_NoticeDAL : BaseDAL<S_Notice>, IS_NoticeDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sNotice = db.S_Notice.FirstOrDefault(s => s.ID == id);  
                db.S_Notice.Remove(sNotice); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public S_Notice GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var sNotice = db.S_Notice.FirstOrDefault(s => s.ID == id);
                return sNotice;
            }
        }

        public bool Update(S_Notice sNotice) {
            using (var db = new LFTHWDBModel())
            {
                var _sNotice = db.S_Notice.FirstOrDefault(s => s.ID == sNotice.ID);
                _sNotice.ID = sNotice.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
