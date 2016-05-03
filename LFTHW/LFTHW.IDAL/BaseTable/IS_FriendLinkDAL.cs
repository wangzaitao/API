using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IS_FriendLinkDAL: IBaseDAL<S_FriendLink>
    {
        bool Delete(int id);

        S_FriendLink GetById(int id);

        bool Update(S_FriendLink sFriendLink);
    }
}
