using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class UP_UserCommentBLL : BaseBLL<UP_UserComment>, IUP_UserCommentBLL
    {
        private readonly IUP_UserCommentDAL _IUP_UserCommentDAL;
        public UP_UserCommentBLL()
            : base()
        {
            _IUP_UserCommentDAL = new UP_UserCommentDAL();
        }

        public bool Delete(int id) {
            return _IUP_UserCommentDAL.Delete(id);
        }

        public UP_UserComment GetById(int id)
        {
            return _IUP_UserCommentDAL.GetById(id);
        }
        public bool Update(UP_UserComment upUserComment)
        {
            return _IUP_UserCommentDAL.Update(upUserComment);
        }
    }
}

