using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_CommentReplyBLL : IBaseBLL<UP_CommentReply>
    {
        bool Delete(int id);
        UP_CommentReply GetById(int id);
        bool Update(UP_CommentReply upCommentReply);
    }
}
