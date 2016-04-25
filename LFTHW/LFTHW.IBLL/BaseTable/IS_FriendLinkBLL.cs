using LFTHW.Model;

namespace LFTHW.IBLL
{
    public interface IS_FriendLinkBLL: IBaseBLL<S_FriendLink>
    {
        bool Delete(int id);
        S_FriendLink GetById(int id);
        bool Update(S_FriendLink sFriendLink);
    }
}
