using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IU_UserAccountDAL: IBaseDAL<U_UserAccount>
    {
        bool Delete(int id);

        U_UserAccount GetById(int id);

        bool Update(U_UserAccount uUserAccount);
    }
}
