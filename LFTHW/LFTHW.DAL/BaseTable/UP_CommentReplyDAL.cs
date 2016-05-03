using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_CommentReplyDAL : BaseDAL<UP_CommentReply>, IUP_CommentReplyDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upCommentReply = db.UP_CommentReply.FirstOrDefault(s => s.ID == id);  
                db.UP_CommentReply.Remove(upCommentReply); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_CommentReply GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upCommentReply = db.UP_CommentReply.FirstOrDefault(s => s.ID == id);
                return upCommentReply;
            }
        }

        public bool Update(UP_CommentReply upCommentReply) {
            using (var db = new LFTHWDBModel())
            {
                var _upCommentReply = db.UP_CommentReply.FirstOrDefault(s => s.ID == upCommentReply.ID);
                _upCommentReply.ID = upCommentReply.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
