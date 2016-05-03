using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class U_UserInfoBLL : BaseBLL<U_UserInfo>, IU_UserInfoBLL
    {
        private readonly IU_UserInfoDAL _IU_UserInfoDAL;
        public U_UserInfoBLL()
            : base()
        {
            _IU_UserInfoDAL = new U_UserInfoDAL();
        }

        public bool Delete(int id) {
            return _IU_UserInfoDAL.Delete(id);
        }

        public U_UserInfo GetById(int id)
        {
            return _IU_UserInfoDAL.GetById(id);
        }
        public bool Update(U_UserInfo uUserInfo)
        {
            return _IU_UserInfoDAL.Update(uUserInfo);
        }
    }
}

