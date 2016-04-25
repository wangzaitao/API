using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_CommentImageDAL: IBaseDAL<UP_CommentImage>
    {
        bool Delete(int id);

        UP_CommentImage GetById(int id);

        bool Update(UP_CommentImage upCommentImage);
    }
}
