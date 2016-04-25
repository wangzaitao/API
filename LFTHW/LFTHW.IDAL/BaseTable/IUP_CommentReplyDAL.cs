using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_CommentReplyDAL: IBaseDAL<UP_CommentReply>
    {
        bool Delete(int id);

        UP_CommentReply GetById(int id);

        bool Update(UP_CommentReply upCommentReply);
    }
}
