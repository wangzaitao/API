using LFTHW.Model;
namespace LFTHW.IBLL
{
    public interface IU_UserInfoBLL : IBaseBLL<U_UserInfo>
    {
        bool Delete(int id);
        U_UserInfo GetById(int id);
        bool Update(U_UserInfo uUserInfo);
    }
}
