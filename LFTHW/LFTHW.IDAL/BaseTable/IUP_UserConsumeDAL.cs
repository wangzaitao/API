using LFTHW.Model;
namespace LFTHW.IDAL
{
    public interface IUP_UserConsumeDAL: IBaseDAL<UP_UserConsume>
    {
        bool Delete(int id);

        UP_UserConsume GetById(int id);

        bool Update(UP_UserConsume upUserConsume);
    }
}
