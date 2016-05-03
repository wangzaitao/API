using System;
using System.Linq;
using System.Transactions;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.DAL
{
    public class UP_CommentImageDAL : BaseDAL<UP_CommentImage>, IUP_CommentImageDAL
    {
        public bool Delete(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upCommentImage = db.UP_CommentImage.FirstOrDefault(s => s.ID == id);  
                db.UP_CommentImage.Remove(upCommentImage); 
                return db.SaveChanges() > 0 ? true : false;
            }
        }

        public UP_CommentImage GetById(int id) {
            using (var db = new LFTHWDBModel())
            {
                var upCommentImage = db.UP_CommentImage.FirstOrDefault(s => s.ID == id);
                return upCommentImage;
            }
        }

        public bool Update(UP_CommentImage upCommentImage) {
            using (var db = new LFTHWDBModel())
            {
                var _upCommentImage = db.UP_CommentImage.FirstOrDefault(s => s.ID == upCommentImage.ID);
                _upCommentImage.ID = upCommentImage.ID;

                return db.SaveChanges() > 0 ? true : false;
            }
        }
    }
}
