using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_UserCommentDAL: IBaseDAL<UP_UserComment>
    {
        bool Delete(int id);

        UP_UserComment GetById(int id);

        bool Update(UP_UserComment upUserComment);
    }
}
