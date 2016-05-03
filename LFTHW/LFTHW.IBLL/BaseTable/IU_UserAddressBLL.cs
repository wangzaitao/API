using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IU_UserAddressBLL : IBaseBLL<U_UserAddress>
    {
        bool Delete(int id);
        U_UserAddress GetById(int id);
        bool Update(U_UserAddress uUserAddress);
    }
}
