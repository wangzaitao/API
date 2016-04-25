using LFTHW.DAL;
using LFTHW.IBLL;
using LFTHW.IDAL;
using LFTHW.Model;

namespace LFTHW.BLL
{
    public class U_UserAddressBLL : BaseBLL<U_UserAddress>, IU_UserAddressBLL
    {
        private readonly IU_UserAddressDAL _IU_UserAddressDAL;
        public U_UserAddressBLL()
            : base()
        {
            _IU_UserAddressDAL = new U_UserAddressDAL();
        }

        public bool Delete(int id) {
            return _IU_UserAddressDAL.Delete(id);
        }

        public U_UserAddress GetById(int id)
        {
            return _IU_UserAddressDAL.GetById(id);
        }
        public bool Update(U_UserAddress uUserAddress)
        {
            return _IU_UserAddressDAL.Update(uUserAddress);
        }
    }
}

