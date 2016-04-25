using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IU_UserAccountBLL : IBaseBLL<U_UserAccount>
    {
        bool Delete(int id);
        U_UserAccount GetById(int id);
        bool Update(U_UserAccount uUserAccount);
    }
}
