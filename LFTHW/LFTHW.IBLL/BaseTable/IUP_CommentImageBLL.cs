using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_CommentImageBLL : IBaseBLL<UP_CommentImage>
    {
        bool Delete(int id);
        UP_CommentImage GetById(int id);
        bool Update(UP_CommentImage upCommentImage);
    }
}
