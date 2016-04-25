using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IU_UserRegBLL : IBaseBLL<U_UserReg>
    {
        bool Delete(int id);
        U_UserReg GetById(int id);
        bool Update(U_UserReg uUserReg);
    }
}
