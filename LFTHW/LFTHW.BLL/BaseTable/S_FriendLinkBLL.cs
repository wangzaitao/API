using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class S_FriendLinkBLL: BaseBLL<S_FriendLink>,IS_FriendLinkBLL
    {
        private readonly IS_FriendLinkDAL _IS_FriendLinkDAL;
        public S_FriendLinkBLL()
            : base()
        {
            _IS_FriendLinkDAL = new S_FriendLinkDAL();
        }

        public bool Delete(int id) {
            return _IS_FriendLinkDAL.Delete(id);
        }

        public S_FriendLink GetById(int id) {
            return _IS_FriendLinkDAL.GetById(id);
        }
        public bool Update(S_FriendLink sFriendLink) {
            return _IS_FriendLinkDAL.Update(sFriendLink);
        }
    }
}
