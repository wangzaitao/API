using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_CommentReplyBLL : BaseBLL<UP_CommentReply>, IUP_CommentReplyBLL
    {
        private readonly IUP_CommentReplyDAL _IUP_CommentReplyDAL;
        public UP_CommentReplyBLL()
            : base()
        {
            _IUP_CommentReplyDAL = new UP_CommentReplyDAL();
        }

        public bool Delete(int id) {
            return _IUP_CommentReplyDAL.Delete(id);
        }

        public UP_CommentReply GetById(int id)
        {
            return _IUP_CommentReplyDAL.GetById(id);
        }
        public bool Update(UP_CommentReply upCommentReply)
        {
            return _IUP_CommentReplyDAL.Update(upCommentReply);
        }
    }
}

