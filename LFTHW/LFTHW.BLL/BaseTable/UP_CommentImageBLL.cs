using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_CommentImageBLL : BaseBLL<UP_CommentImage>, IUP_CommentImageBLL
    {
        private readonly IUP_CommentImageDAL _IUP_CommentImageDAL;
        public UP_CommentImageBLL()
            : base()
        {
            _IUP_CommentImageDAL = new UP_CommentImageDAL();
        }

        public bool Delete(int id) {
            return _IUP_CommentImageDAL.Delete(id);
        }

        public UP_CommentImage GetById(int id)
        {
            return _IUP_CommentImageDAL.GetById(id);
        }
        public bool Update(UP_CommentImage upCommentImage)
        {
            return _IUP_CommentImageDAL.Update(upCommentImage);
        }
    }
}

