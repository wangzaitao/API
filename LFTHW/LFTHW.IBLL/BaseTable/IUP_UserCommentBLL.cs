using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IUP_UserCommentBLL : IBaseBLL<UP_UserComment>
    {
        bool Delete(int id);
        UP_UserComment GetById(int id);
        bool Update(UP_UserComment upUserComment);
    }
}
