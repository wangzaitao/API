using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class U_UserAccountBLL : BaseBLL<U_UserAccount>, IU_UserAccountBLL
    {
        private readonly IU_UserAccountDAL _IU_UserAccountDAL;
        public U_UserAccountBLL()
            : base()
        {
            _IU_UserAccountDAL = new U_UserAccountDAL();
        }

        public bool Delete(int id) {
            return _IU_UserAccountDAL.Delete(id);
        }

        public U_UserAccount GetById(int id)
        {
            return _IU_UserAccountDAL.GetById(id);
        }
        public bool Update(U_UserAccount uUserAccount)
        {
            return _IU_UserAccountDAL.Update(uUserAccount);
        }
    }
}

