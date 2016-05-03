using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IU_UserInfoDAL: IBaseDAL<U_UserInfo>
    {
        bool Delete(int id);

        U_UserInfo GetById(int id);

        bool Update(U_UserInfo uUserInfo);
    }
}
