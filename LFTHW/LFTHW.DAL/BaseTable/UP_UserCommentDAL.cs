using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_UserCommentDAL : BaseDAL<UP_UserComment>, IUP_UserCommentDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upUserComment = db.UP_UserComment.FirstOrDefault(s => s.ID == id);  
                db.UP_UserComment.Remove(upUserComment); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_UserComment GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upUserComment = db.UP_UserComment.FirstOrDefault(s => s.ID == id);
                return upUserComment;
            }
        }

        public bool Update(UP_UserComment upUserComment) {
            using (var db = new LFTHWDBModel())
            {
                var _upUserComment = db.UP_UserComment.FirstOrDefault(s => s.ID == upUserComment.ID);
                _upUserComment.ID = upUserComment.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
