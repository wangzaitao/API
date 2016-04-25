using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IU_UserRegDAL: IBaseDAL<U_UserReg>
    {
        bool Delete(int id);

        U_UserReg GetById(int id);

        bool Update(U_UserReg uUserReg);
    }
}
