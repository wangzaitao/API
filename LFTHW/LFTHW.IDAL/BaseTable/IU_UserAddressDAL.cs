using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IU_UserAddressDAL: IBaseDAL<U_UserAddress>
    {
        bool Delete(int id);

        U_UserAddress GetById(int id);

        bool Update(U_UserAddress uUserAddress);
    }
}
