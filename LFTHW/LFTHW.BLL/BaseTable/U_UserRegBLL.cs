using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class U_UserRegBLL : BaseBLL<U_UserReg>, IU_UserRegBLL
    {
        private readonly IU_UserRegDAL _IU_UserRegDAL;
        public U_UserRegBLL()
            : base()
        {
            _IU_UserRegDAL = new U_UserRegDAL();
        }

        public bool Delete(int id) {
            return _IU_UserRegDAL.Delete(id);
        }

        public U_UserReg GetById(int id)
        {
            return _IU_UserRegDAL.GetById(id);
        }
        public bool Update(U_UserReg uUserReg)
        {
            return _IU_UserRegDAL.Update(uUserReg);
        }
    }
}

